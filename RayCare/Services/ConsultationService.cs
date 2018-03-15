using RayCare.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayCare.Services
{
    class ConsultationService
    {
        public static void addConsultation(Consultation consultation)
        {
            HospitalConfiguration hospitalConfiguration = HospitalConfiguration.GetInstance();
            hospitalConfiguration.Consultations.Add(consultation);
        }
    }
}
