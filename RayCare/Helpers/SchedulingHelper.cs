using RayCare.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayCare.Helpers
{
    public static class SchedulingHelper
    {
        public static Consultation scheduleConsultation(List<TreatmentRoom> rooms, List<Doctor> doctors, int startDay)
        {
            for (int day = startDay; day < Calendar.NUM_DAYS; day++)
            {
                bool isDoctorAvailable = false;
                Doctor availableDoctor = new Doctor();
                foreach(Doctor doctor in doctors)
                {
                    if (doctor.calender.isAvailable(day))
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
                    if (room.calender.isAvailable(day))
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
                    availableDoctor.calender.book(day);
                    availableRoom.calender.book(day);
                    return consultation;
                }
            }
            throw new InvalidOperationException("No availability for appointment");
        }
    }
}
