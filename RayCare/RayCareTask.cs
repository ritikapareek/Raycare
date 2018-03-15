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
            while (true)
            {
                DisplayHomeScreen();
                Console.WriteLine("\nPress any key to continue. Press q to quit.");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.KeyChar == 'q')
                    break;
            }
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
            HospitalConfiguration.SetInstance(JsonHelper.ReadJsonFile());
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
                    HospitalService.ReadPatientInformationAndSchedule();
                    break;
                case 2:
                    HospitalService.ShowRegisteredPatients();
                    break;
                case 3:
                    HospitalService.ShowConsultations();
                    break;
                default:
                    break;
            }
        }

    }
}
