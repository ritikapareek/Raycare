using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayCare.Helpers
{
    class PatientHelper
    {
        public static void printPatientInfo(Patient patient)
        {
            Console.WriteLine("____________________Patient Information____________________");
            Console.WriteLine("Name: " + patient.Name);
            Console.WriteLine("Condition: " + patient.Condition.ToString());
        }
    }
}
