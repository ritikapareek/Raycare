using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RayCare.Model;
using RayCare.Helpers;

namespace RayCare.Services
{
    public static class HospitalService
    {
        public static void AddPatient(Patient patient)
        {
            HospitalConfiguration.GetInstance().Patients.Add(patient);
        }

        public static void showRegisteredPatients()
        {
            Console.Clear();
            if (HospitalConfiguration.GetInstance().Patients.Count() == 0)
            {
                Console.WriteLine("No registered patients yet.");
                return;
            }
            HospitalConfiguration.GetInstance().Patients.ForEach(patient => PatientHelper.printPatientInfo(patient));
        }

        public static void showConsultations()
        {
            Console.Clear();
            if (HospitalConfiguration.GetInstance().Consultations.Count() == 0)
            {
                Console.WriteLine("No scheduled consultations yet.");
                return;
            }
            HospitalConfiguration.GetInstance().Consultations.ForEach(consultation => ConsultationHelper.PrintConsultationInfo(consultation));
        }

        public static void ReadPatientInformationAndSchedule()
        {
            Console.Clear();
            Patient patient = PatientService.AddPatientInformationFromUser();
            HospitalService.AddPatient(patient);
            Consultation consultation = SchedulingService.GetInstance().Schedule(patient, 0);
            ConsultationService.addConsultation(consultation);
            ConsultationHelper.PrintConsultationInfo(consultation);
        }
    }
}
