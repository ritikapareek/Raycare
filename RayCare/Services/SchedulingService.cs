using RayCare.Helpers;
using RayCare.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RayCare.Services
{
    /// <summary>
    /// This searches for an empty schedule and books an appointment for a patient.
    /// Making this an singleton as we do not want scheduling to come from multiple objects to avoid race conditions.
    /// </summary>
    public class SchedulingService
    {
        private static SchedulingService instance;

        private SchedulingService()
        { }

        public static SchedulingService GetInstance()
        {
            if (instance == null)
                instance = new SchedulingService();
            return instance;
        }

        /// <summary>
        /// Schedule a patient
        /// </summary>
        /// <param name="patient"></param>
        /// <param name="registrationDay"></param>
        /// <returns></returns>
        public Consultation Schedule(Patient patient, int registrationDay)
        {
            List<TreatmentRoom> rooms = new List<TreatmentRoom>();
            List<Doctor> doctors = new List<Doctor>();

            HospitalConfiguration hc = HospitalConfiguration.GetInstance();
            if (patient.Condition.conditionType.Equals(ConditionType.Cancer))
            {
                AddDoctors(Role.Oncologist, ref doctors);
                if(((CancerCondition)patient.Condition).TopographyType.Equals(TopographyType.HeadAndNeck))
                {
                    List<Capability> capabilities = new List<Capability>();
                    capabilities.Add(Capability.Advanced);
                    AddMachineRooms(ref rooms, capabilities, true);
                } else
                {
                    List<Capability> capabilities = new List<Capability>();
                    capabilities.Add(Capability.Simple);
                    capabilities.Add(Capability.Advanced);
                    AddMachineRooms(ref rooms, capabilities, true);
                }
            } else
            {
                AddDoctors(Role.GeneralPractitioner, ref doctors);
                AddMachineRooms(ref rooms, new List<Capability>(), false);
            }

            try {
                Consultation consultation = SchedulingHelper.ScheduleConsultation(rooms, doctors, registrationDay + 1);
                consultation.patient = patient;
                return consultation;
            } catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        private void AddMachineRooms(ref List<TreatmentRoom> rooms, List<Capability> capabilities, bool treatmentMachineNeeded)
        {
            HospitalConfiguration hc = HospitalConfiguration.GetInstance();
            List<TreatmentRoom> allRooms = hc.TreatmentRooms;

            if (treatmentMachineNeeded)
            {
                rooms = allRooms.Where(tr => tr.TreatmentMachine != null)
                    .Where(tr => capabilities.Contains(GetCapabilitiesOfARoom(tr)))
                    .ToList();
            } else
            {
                rooms = allRooms;
            }
        }

        private Capability GetCapabilitiesOfARoom(TreatmentRoom room)
        {
            return HospitalConfiguration.GetInstance()
                .TreatmentMachines
                .Where(tm => tm.Name == room.TreatmentMachine)
                .Select(rm => rm.Capability)
                .ToList()
                .First();
        }


        private void AddDoctors(Role role, ref List<Doctor> doctors)
        {
            HospitalConfiguration hc = HospitalConfiguration.GetInstance();
            doctors = hc.Doctors.Where(d => d.Roles.Contains(role)).ToList();
        }
    }
}
