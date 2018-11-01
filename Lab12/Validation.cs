using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab12
{
    static class Validation
    {
        public static string GetResponse(string message)
        {
            Console.Write(message);
            return Console.ReadLine();

        }

        public static string GetString(string message)
        {
            Console.Write(message);
            string answer = Console.ReadLine();

            while (true)
            {
                if (Regex.IsMatch(answer, @"[0-9]"))
                {
                    answer = GetString($"{answer} is not a valid input, please do not enter any numbers.");
                    continue;
                }
                else
                {
                    return answer;
                }
            }
        }

        public static int GetScore(string message)
        {
            int number;

            while (true)
            {
                Console.Write(message);
                bool parsed = int.TryParse(Console.ReadLine(), out number);
                if (!parsed || number < 0 || number > 100)
                {
                    Console.WriteLine("That is not valid, please enter a number between 0 and 100.");
                }
                else
                {
                    return number;
                }
            }
        }

        public static int GetInt(string message)
        {
            int number;

            while (true)
            {
                Console.Write(message);
                bool parsed = int.TryParse(Console.ReadLine(), out number);
                if (!parsed || number < 0)
                {
                    Console.WriteLine("That is not valid, please enter a positive number.");
                }
                else
                {
                    return number;
                }
            }
        }

        public static double GetDouble(string message)
        {
            double number;

            while (true)
            {
                Console.Write(message);
                bool parsed = double.TryParse(Console.ReadLine(), out number);
                if (!parsed || number < 0)
                {
                    Console.WriteLine("That is not valid, please enter a positive number.");
                }
                else
                {
                    return number;
                }
            }
        }
    }
}
