using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using the_fan_s_guide.Models;

namespace the_fan_s_guide.Forms_Validation
{
    public static class FieldsValidation
    {
       public static string GetProblemMessage(string firstName, string lastName, string citizenship, string nationality, string height, string sport,string team, string persRecord, string recordsman)
        {
            var problemMessage = "";
            if(string.IsNullOrWhiteSpace(firstName) || !OnlyLetters(firstName) || firstName.Length>50 && firstName.Length<1)
            {
                problemMessage += "First name cannot be empty and must contain only less than 50 letters!.\n";
            }
            if (string.IsNullOrEmpty(lastName) || !OnlyLetters(lastName) || lastName.Length>50)
            {
                problemMessage += "Last name cannot be empty and must contain only less than 50 letters!.\n";
            }

            if (citizenship.Length>50 )
            {
                problemMessage += "Citizenship cannot be empty and must contain only less than 50 letters!\n";
            }

            if (string.IsNullOrEmpty(nationality) || !OnlyLetters(nationality) || nationality.Length>50)
            {
                problemMessage += "Nationality cannot be empty and must contain only less than 50 letters!\n";
            }

            bool heightOk = int.TryParse(height, out int parsedHeight);
            if (!heightOk || parsedHeight <= 0 || height.Length >= 4)
            {
                problemMessage += "Height must by a positive number and must contain only less than 4 symbols.\n";
            }

            if (string.IsNullOrEmpty(sport) || !OnlyLetters(sport) || sport.Length>50)
            {
                problemMessage += "Kind of sport cannot be empty and must contain only less than 50 letters!\n";
            }

            if(team.Length > 100)
            {
                problemMessage += "Team must only contain less than 100 symbols!";
            }

            if (persRecord.Length > 100)
            {
                problemMessage += "Personal record must only contain less than 100 symbols!";
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
                if ((!char.IsLetter(i)) && i != '-')
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

