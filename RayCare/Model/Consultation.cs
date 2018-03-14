using System;

namespace RayCare.Model
{
    /// <summary>
    /// This describes the consulation appointnment scheduled.
    /// </summary>
    public class Consultation
    {
        public string Id { get; set; }
        public string PatientId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string DoctorId { get; set; }
        public string RoomName { get; set; }
        public DateTime ConsultationDate { get; set; }
    }
}
