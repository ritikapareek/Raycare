using RayCare.Model;
using System;

namespace RayCare.Helpers
{
    /// <summary>
    /// Describes the helper function for consultation.
    /// </summary>
    public static class ConsultationHelper
    {
        /// <summary>
        /// Prints the consultation info:
        /// Patient name, doctor assigned, room number,
        /// and consultation date.
        /// </summary>
        /// <param name="consultation"></param>
        public static void PrintConsultationInfo(Consultation consultation)
        {
            Console.WriteLine("__________________Consultation Information__________________");
            Console.WriteLine("Patient: " + consultation.patient.Name);
            Console.WriteLine("Doctor: " + consultation.doctor.Name);
            Console.WriteLine("Room: " + consultation.room.Name);
            Console.WriteLine("Date of appointment: " + consultation.ConsultationDate.ToString("dd-MMM-yyyy (dddd)"));
        }
    }
}
