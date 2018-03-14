namespace RayCare.Model
{
    /// <summary>
    /// Initializes the Hospital Configuration using Singelton Pattern.
    /// </summary>
    public class HospitalConfiguration
    {
        private static HospitalConfiguration instance;

        private HospitalConfiguration()
        { }

        public static HospitalConfiguration GetHospitalConfiguration()
        {
            if (instance == null)
                instance = new HospitalConfiguration();
            return instance;
        }

        public Doctor[] Doctors { get; set; }

        public TreatmentMachine[] TreatmentMachines { get; set; }

        public TreatmentRoom[] TreatmentRooms { get; set; }
    }
}
