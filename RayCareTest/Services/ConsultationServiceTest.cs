using Microsoft.VisualStudio.TestTools.UnitTesting;
using RayCare.Model;
using RayCare.Services;

namespace RayCareTest.Services
{
    [TestClass]
    public class ConsultationServiceTest
    {
        [TestMethod]
        public void Test_AddConsultation()
        {
           HospitalConfiguration hospitalConfiguration = HospitalConfiguration.GetInstance();
            Consultation consultation = new Consultation();
            ConsultationService.AddConsultation(consultation);
            Assert.AreEqual(hospitalConfiguration.Consultations[0], consultation);
            Assert.AreEqual(hospitalConfiguration.Consultations.Count, 1);
        }
    }
}
