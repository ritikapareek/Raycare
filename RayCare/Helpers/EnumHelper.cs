using System;

namespace RayCare.Helpers
{
    public static class EnumHelper
    {
        public static Enum ReadEnumValueFromUser(Type enumGeneric)
        {
            int i = 1;
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
            // and checking if the integer enterd is within the enum index bound 
            if (isUserInputValid && userInput > 0 && userInput <= enumValues.Length)
            {
                return (Enum)enumValues.GetValue(userInput - 1);
            }
            else { 
                Console.WriteLine("Invalid input, please try again");
                return ReadEnumValueFromUser(enumGeneric);
            } 
        }
    }
}
