using Newtonsoft.Json;
using System.IO;
using RayCare.Model;
using System;
using System.Text;

namespace RayCare.Helpers
{
    /// <summary>
    /// Describes various helper functions for json.
    /// </summary>
    public static class JsonHelper
    {
        /// <summary>
        /// Reads the sample Json object from file and puts in the HospitalConfiguration.
        /// </summary>
        /// <returns>Hospital Configuration</returns>
        public static HospitalConfiguration ReadJsonFile()
        {
            string bytesAsString = Encoding.UTF8.GetString(Properties.Resources.InitialHospitalData);

            // Read file into a string and deserialize JSON to a type
            return JsonConvert.DeserializeObject<HospitalConfiguration>(bytesAsString);
        }
    }
}
