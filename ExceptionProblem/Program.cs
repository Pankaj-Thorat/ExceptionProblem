using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] ages = { "10", "20", "35", "70", null, "abc", "" };

            foreach (var age in ages)
            {
                try
                {
                    string category = AgeCategorizer.CategorizeAge(age);
                    Console.WriteLine($"Age: {age}, Category: {category}");
                }
                catch (InvalidAgeException e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }
        }
    }
}
