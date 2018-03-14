using System;
using RayCare.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayCare.Services
{
    public static class PatientService
    {
        public static Patient AddPatientInformationFromUser()
        {
            Patient patient = new Patient();
            Console.WriteLine("Enter your name");
            patient.Name = Console.ReadLine();

            Console.WriteLine("Enter your condition");
            ConditionType patientCondition = (ConditionType)EnumHelper.ReadEnumValueFromUser(typeof(ConditionType));

            switch (patientCondition)
            {
                case ConditionType.Cancer:
                    patient.Condition = PatientConditionService.readCancerServiceFromUser();
                    break;
                case ConditionType.Flu:
                    patient.Condition = new FluCondition();
                    break;

            }

            return patient;
        }
    }
}
