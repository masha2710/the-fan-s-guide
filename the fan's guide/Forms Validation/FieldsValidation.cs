using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_fan_s_guide.Forms_Validation
{
    public static class FieldsValidation
    {
       public static string GetProblemMessage(string firstName, string lastName, string citizenship, string nationality, string height, string sport, string recordsman)
        {
            var problemMessage = "";
            if(string.IsNullOrEmpty(firstName) || !OnlyLetters(firstName))
            {
                problemMessage += "First name cannot be empty and must contain only letters!.\n";
            }
            if (string.IsNullOrEmpty(lastName) || !OnlyLetters(lastName))
            {
                problemMessage += "Last name cannot be empty and must contain only letters!.\n";
            }

            if (string.IsNullOrEmpty(citizenship) || !OnlyLetters(citizenship))
            {
                problemMessage += "Citizenship cannot be empty and must contain only letters!\n";
            }

            if (string.IsNullOrEmpty(nationality) || !OnlyLetters(nationality))
            {
                problemMessage += "Nationality cannot be empty and must contain only letters!\n";
            }

            bool heightOk = int.TryParse(height, out int parsedHeight);
            if (!heightOk || parsedHeight <= 0)
            {
                problemMessage += "Height must by a positive number.\n";
            }

            if (string.IsNullOrEmpty(sport) || !OnlyLetters(sport))
            {
                problemMessage += "Kind of sport cannot be empty and must contain only letters!\n";
            }

            if (string.IsNullOrEmpty(recordsman) || !YesorNo(recordsman))
            {
                problemMessage += "Please, enter 'yes' or 'no'.";
            }
            return problemMessage;
        }
        public static bool OnlyLetters(string info)
        {
            foreach (char i in info)
            {
                if (!char.IsLetter(i))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool YesorNo(string input)
        {
            string lowerInput = input.ToLower();
            if (lowerInput == "no")
            {
                return true;
            }
            if (lowerInput == "yes")
            {
                return true;
            }
            return false;
        }
    }
}

