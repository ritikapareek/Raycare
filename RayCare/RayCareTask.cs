using RayCare.Helpers;
using RayCare.Model;
using RayCare.Services;
using System;

namespace RayCare
{
    class RayCareTask
    {
        static void Main(string[] args)
        {
            Initialize();
            DisplayHomeScreen();
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
            HospitalConfiguration.setInstance(Helper.ReadJsonFile());
        }

        private static void DisplayHomeScreen()
        {
            Console.Clear();
            Console.WriteLine("Welcome to RayCare!");
            Console.WriteLine("Select one of the following options:");
            Console.WriteLine("Enter 1 for Patient Registration");
            Console.WriteLine("Enter 2 to Get the list of registered patients");
            Console.WriteLine("Enter 3 to Get the list of scheduled consultants");
            int userInput = -1;
            bool isUserInputValid = Int32.TryParse(Console.ReadLine(), out userInput);
            if (!isUserInputValid)
            {
                Console.WriteLine("Oops, try again please");
                return;
            }
            switch (userInput)
            {
                case 1:
                    ReadPatientInformationAndSchedule();
                    Console.ReadLine();
                    break;
                case '2':
                    Console.WriteLine("hi");
                    Console.ReadLine();
                    break;
                case '3':
                    Console.WriteLine("hi");
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
        }

        private static void ReadPatientInformationAndSchedule()
        {
            Console.Clear();
            Patient patient = PatientService.AddPatientInformationFromUser();
            HospitalConfiguration hospitalConfiguration = HospitalConfiguration.GetInstance();
            HospitalConfigurationService.AddPatient(patient);
            Consultation consultation = SchedulingService.GetInstance().Schedule(patient);
            ConsultationHelper.DisplayConsultation(consultation);
            
        }
    }
}
