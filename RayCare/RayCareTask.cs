using RayCare.Helpers;
using RayCare.Model;

namespace RayCare
{
    class RayCareTask
    {
        static void Main(string[] args)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes the application by initializing the hospital.
        /// </summary>
        private static void Initialize()
        {
            InitializeHospitalConfiguration();
        }

        /// <summary>
        /// Initializes hospital configuration.
        /// </summary>
        private static void InitializeHospitalConfiguration()
        {
            HospitalConfiguration hc = Helper.ReadJsonFile();
        }
    }
}
