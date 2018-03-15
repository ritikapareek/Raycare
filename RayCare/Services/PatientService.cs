using System;
using RayCare.Helpers;

namespace RayCare.Services
{
    /// <summary>
    /// This describes the services for Patient
    /// like adding patient information.
    /// </summary>
    public static class PatientService
    {
        /// <summary>
        /// Gets patient's name and condition from the user.
        /// Sets the user condition & toppography.
        /// </summary>
        /// <returns></returns>
        public static Patient AddPatientInformationFromUser()
        {
            Patient patient = new Patient();
            
            do
            {
                Console.WriteLine("Enter your name:");
                patient.Name = Console.ReadLine();
            } while (patient.Name == string.Empty);

            Console.WriteLine("Enter your condition:");
            ConditionType patientCondition = (ConditionType)EnumHelper.ReadEnumValueFromUser(typeof(ConditionType));

            switch (patientCondition)
            {
                case ConditionType.Cancer:
                    patient.Condition = PatientConditionService.ReadCancerServiceFromUser();
                    break;
                case ConditionType.Flu:
                    patient.Condition = new FluCondition();
                    break;
            }
            return patient;
        }
    }
}
