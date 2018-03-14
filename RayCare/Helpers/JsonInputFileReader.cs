using Newtonsoft.Json;
using System.IO;
using RayCare.Model;

namespace RayCare.Helpers
{
    public static class Helper
    {
        /// <summary>
        /// Reads the sample Json object from file and puts in the HospitalConfiguration.
        /// </summary>
        /// <returns>Hospital Configuration</returns>
        public static HospitalConfiguration ReadJsonFile()
        {
            // Read file into a string and deserialize JSON to a type
            return JsonConvert.DeserializeObject<HospitalConfiguration>(File.ReadAllText(@"E:\Workspace\Project\InitialHospitalData.json"));
        }
    }
}
