using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayCare.Helpers
{
    public static class EnumHelper
    {
        //public static Enum ReadEnumValueFromUser(Enum enumGeneric)
        //{
        //    //foreach (var item in Enum.GetValues( .GetValues(enumGeneric)
        //    //{

        //    //}
        //    //int i = 0;
        //    //// Getting all the values of this enum type
        //    //var enumValues = Enum.GetValues(enumGeneric).ToList();
        //    //foreach (T enumVal in enumValues)
        //    //{
        //    //    Console.WriteLine(i + "." + enumVal);
        //    //}
        //    //Console.WriteLine("Select one of the above options");
        //    //ConsoleKeyInfo info = Console.ReadKey();

        //    //int userInput = (int)info.KeyChar;
        //    //if (userInput < 0 || userInput > enumValues.Count() - 1)
        //    //{
        //    //    Console.WriteLine("Invalid input, please try again");
        //    //    return ReadEnumValueFromUser(enumGeneric);
        //    //}
        //    return enumGeneric ;
        //}

        /// <summary>
        /// This shows all the volues of an enum the user. The user is then prompted to select one of the values.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumGeneric"></param>
        /// <returns>Enum with the value user selected.</returns>


        public static Enum ReadEnumValueFromUser(Type enumGeneric)
        {
            int i = 0;
            // Getting all the values of this enum type
            var enumValues = Enum.GetValues(enumGeneric);
            foreach (var enumVal in enumValues)
            {
                Console.WriteLine(i + "." + enumVal);
                i++;
            }
            Console.WriteLine("Select one of the above options");
            int userInput = 0;
            bool isUserInputValid = Int32.TryParse(Console.ReadLine(), out userInput);
            // Checking if the user entered a string which is an integer
            // and checking if the integer enters 
            if (isUserInputValid && userInput >= 0 && userInput < enumValues.Length)
            {
                return (Enum)enumValues.GetValue(userInput);
            }
            else { 
                Console.WriteLine("Invalid input, please try again");
                return ReadEnumValueFromUser(enumGeneric);
            } 
        }
    }
}
