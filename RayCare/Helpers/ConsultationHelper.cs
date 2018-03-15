using RayCare.Model;
using System;

namespace RayCare.Helpers
{
    public static class ConsultationHelper
    {
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
