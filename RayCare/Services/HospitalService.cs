using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RayCare.Model;
using RayCare.Helpers;

namespace RayCare.Services
{
    /// <summary>
    /// Describes the Hospital Service to perform various functions 
    /// like Add Patient, ShowRegisteredPatients.
    /// </summary>
    public static class HospitalService
    {
        /// <summary>
        /// Adds a patient to the hospital configuration.
        /// </summary>
        /// <param name="patient"></param>
        public static void AddPatient(Patient patient)
        {
            HospitalConfiguration.GetInstance().Patients.Add(patient);
        }

        /// <summary>
        /// Displays all the registered patients in the hospital.
        /// </summary>
        public static void ShowRegisteredPatients()
        {
            if (!Console.IsOutputRedirected) Console.Clear();
            if (HospitalConfiguration.GetInstance().Patients.Count() == 0)
            {
                Console.WriteLine("No registered patients yet.");
                return;
            }
            HospitalConfiguration.GetInstance().Patients.ForEach(patient => PatientHelper.PrintPatientInfo(patient));
        }

        /// <summary>
        /// Displays all the consulations in the hospital.
        /// </summary>
        public static void ShowConsultations()
        {
            Console.Clear();
            if (HospitalConfiguration.GetInstance().Consultations.Count() == 0)
            {
                Console.WriteLine("No scheduled consultations yet.");
                return;
            }
            HospitalConfiguration.GetInstance().Consultations.ForEach(consultation => ConsultationHelper.PrintConsultationInfo(consultation));
        }

        /// <summary>
        /// Reads the patient information, schedule and prints the consultation
        /// information.
        /// </summary>
        public static void ReadPatientInformationAndSchedule()
        {
            Console.Clear();
            Patient patient = PatientService.AddPatientInformationFromUser();
            AddPatient(patient);
            Consultation consultation = SchedulingService.GetInstance().Schedule(patient, 0);
            ConsultationService.AddConsultation(consultation);
            ConsultationHelper.PrintConsultationInfo(consultation);
        }
    }
}
