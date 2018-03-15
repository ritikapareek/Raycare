using Microsoft.VisualStudio.TestTools.UnitTesting;
using RayCare.Model;
using RayCare.Services;
using RayCare;

namespace RayCareTest.Services
{
    [TestClass]
    public class HospitalServiceTest
    {
        
        [TestMethod]
        public void Test_AddPatient()
        {
            Patient patient = new Patient();
            HospitalConfiguration hospitalConfiguration = HospitalConfiguration.GetInstance();
            HospitalService.AddPatient(patient);
            Assert.AreEqual(hospitalConfiguration.Patients[0], patient);
            Assert.AreEqual(hospitalConfiguration.Patients.Count, 1);
        }

    }
}
