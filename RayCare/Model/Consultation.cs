using System;

namespace RayCare.Model
{
    /// <summary>
    /// This describes the consulation appointnment scheduled.
    /// </summary>
    public class Consultation
    {
        public Patient patient { get; set; }
        public DateTime RegistrationDate { get; set; }
        public Doctor doctor { get; set; }
        public TreatmentRoom room { get; set; }
        public DateTime ConsultationDate { get; set; }
    }
}
