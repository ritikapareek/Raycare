using RayCare.Model;

namespace RayCare.Services
{
    /// <summary>
    /// Describes the Consultation Service.
    /// </summary>
    public class ConsultationService
    {
        /// <summary>
        /// Add Consultation adds a consultation to the hospital configuration.
        /// </summary>
        /// <param name="consultation"></param>
        public static void AddConsultation(Consultation consultation)
        {
            HospitalConfiguration hospitalConfiguration = HospitalConfiguration.GetInstance();
            hospitalConfiguration.Consultations.Add(consultation);
        }
    }
}
