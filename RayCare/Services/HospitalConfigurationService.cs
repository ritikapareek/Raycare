using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RayCare.Model;

namespace RayCare.Services
{
    public static class HospitalConfigurationService
    {
        public static void AddPatient(Patient patient)
            {
            HospitalConfiguration.GetInstance().Patients.Add(patient);
        }
    }
}
