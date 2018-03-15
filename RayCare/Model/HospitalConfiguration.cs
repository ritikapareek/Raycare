using System.Collections.Generic;
using RayCare.Model;
namespace RayCare.Model
{
    /// <summary>
    /// Initializes the Hospital Configuration using Singelton Pattern.
    /// </summary>
    public class HospitalConfiguration
    {
        private static HospitalConfiguration instance;

        private HospitalConfiguration()
        {
            Patients = new List<Patient>();
            Consultations = new List<Consultation>();
        }

        public static HospitalConfiguration GetInstance()
        {
            if (instance == null)
                instance = new HospitalConfiguration();
            return instance;
        }
        public static HospitalConfiguration setInstance(HospitalConfiguration externalinstance)
        {
            if (instance != null)
                return instance;
            instance = externalinstance;

            return instance; ;
        }

        public List<Doctor> Doctors { get; set; }

        public List<TreatmentMachine> TreatmentMachines { get; set; }

        public List<TreatmentRoom> TreatmentRooms { get; set; }

        public List<Patient> Patients { get; set; }

        public List<Consultation> Consultations { get; set; }
    }
}
