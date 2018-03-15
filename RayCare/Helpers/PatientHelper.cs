using System;

namespace RayCare.Helpers
{
    /// <summary>
    /// Describes various helper functions for the patient.
    /// </summary>
    public class PatientHelper
    {
        /// <summary>
        /// Displays the patient information:
        /// Patient name and condition type.
        /// </summary>
        /// <param name="patient"></param>
        public static void PrintPatientInfo(Patient patient)
        {
            Console.WriteLine("____________________Patient Information____________________");
            Console.WriteLine("Name: " + patient.Name);
            Console.WriteLine("Condition: " + patient.Condition.conditionType.ToString());
        }
    }
}
