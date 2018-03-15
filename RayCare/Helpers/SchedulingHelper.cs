using RayCare.Model;
using System;
using System.Collections.Generic;

namespace RayCare.Helpers
{
    /// <summary>
    /// Describes various helper functions for scheduling.
    /// </summary>
    public static class SchedulingHelper
    {
        /// <summary>
        /// Schedule a consultation if all the validations satisfies the conditions.
        /// </summary>
        /// <param name="rooms"></param>
        /// <param name="doctors"></param>
        /// <param name="startDay"></param>
        /// <returns>Consultaion for a patient.</returns>
        public static Consultation ScheduleConsultation(List<TreatmentRoom> rooms, List<Doctor> doctors, int startDay)
        {
            for (int day = startDay; day < Calendar.NUM_DAYS; day++)
            {
                bool isDoctorAvailable = false;
                Doctor availableDoctor = new Doctor();
                foreach(Doctor doctor in doctors)
                {
                    if (doctor.calender.IsAvailable(day))
                    {
                        isDoctorAvailable = true;
                        availableDoctor = doctor;
                        break;
                    }
                }

                bool isRoomAvailable = false;
                TreatmentRoom availableRoom = new TreatmentRoom();
                foreach (TreatmentRoom room in rooms)
                {
                    if (room.calender.IsAvailable(day))
                    {
                        isRoomAvailable = true;
                        availableRoom = room;
                        break;
                    }
                }

                if (isRoomAvailable && isDoctorAvailable)
                {
                    Consultation consultation = new Consultation();
                    consultation.doctor = availableDoctor;
                    consultation.room = availableRoom;
                    consultation.ConsultationDate = DateTime.Now.AddDays(day);
                    consultation.RegistrationDate = DateTime.Now.AddDays(startDay - 1);
                    availableDoctor.calender.Book(day);
                    availableRoom.calender.Book(day);
                    return consultation;
                }
            }
            throw new InvalidOperationException("No availability for appointment");
        }
    }
}
