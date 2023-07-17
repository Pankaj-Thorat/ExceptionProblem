using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionProblem
{
    public class AgeCategorizer
    {
        public static string CategorizeAge(string age)
        {
            if (string.IsNullOrEmpty(age))
            {
                throw new InvalidAgeException("Invalid age: Age cannot be null or empty.");
            }

            if (!int.TryParse(age, out int parsedAge))
            {
                throw new InvalidAgeException("Invalid age: Age must be a valid integer.");
            }

            if (parsedAge >= 1 && parsedAge <= 14)
            {
                return "Children";
            }
            else if (parsedAge >= 15 && parsedAge <= 24)
            {
                return "Youth";
            }
            else if (parsedAge >= 25 && parsedAge <= 64)
            {
                return "Adults";
            }
            else if (parsedAge >= 65)
            {
                return "Seniors";
            }
            else
            {
                throw new InvalidAgeException("Invalid age: Age must be a positive integer.");
            }
        }
    }
}
