using System;
using System.Collections.Generic;
using System.Linq;

namespace Excercise1
{
    internal class Program
    {

        private static void Main(string[] args)
        {

            CurrentDate();
            NumberOfDaysElapsed();
            NextLeapYearStartsWithTuesday();
            Console.WriteLine("Please Enter the email");
            var email = Console.ReadLine();
            Console.WriteLine(IsEmailValid(email));
            SumOfNumbers();
            Console.ReadLine();

        }

        //Method to find the current date in year, month, day format

        public static void CurrentDate()
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            Console.WriteLine(dateTime.ToString("yyyy/MM/dd"));

        }

        //Number of days Elapsed Days since start of the year
        //using TimeSpan
        public static void NumberOfDaysElapsed()
        {
            DateTime currentDate = DateTime.Now;

            DateTime firstDayOfYear = new DateTime(currentDate.Year, 1, 1);
            TimeSpan elapsedTime = currentDate.Subtract(firstDayOfYear);
            var day = elapsedTime.Days;
            Console.WriteLine("Number of days elapsed since start of the year is {0}", day);
        }


        //Find Next Leap year that starts with Tuesday
        //Using DateTime.IsLeapYear(Int32) Method
        public static void NextLeapYearStartsWithTuesday()
        {
            for (var year = 2019; year <= 9999; year++)
            {
                if (!DateTime.IsLeapYear(year)) continue;
                DateTime dt = new DateTime(year, 1, 1);
                var nisham = Convert.ToString(dt.DayOfWeek);

                if (nisham != "Tuesday") continue;
                Console.WriteLine("Next Leap Year that starts with a Tuesday would be {0}", year);
                break;
            }

        }

        /// Validate an email address
        /// Using System.Net.Mail.MailAddress method
        public static string IsEmailValid(string email)
        {
            try
            {
                var emailvalidator = new System.Net.Mail.MailAddress(email);
                return "Email is Valid";
            }
            catch
            {
                return "Email not Valid";
            }
        }

        //Find Sum of numbers entered by User
        static void SumOfNumbers()
        {

            {

                decimal total = 0, count = 0;
                Console.WriteLine("Enter Numbers and Enter OK to find their sum");
                string a = Console.ReadLine();
                List<int> numbers = new List<int>();

                while (a.ToLower() != "ok")
                {
                    numbers.Add(Convert.ToInt32(a));
                    count++;
                    a = Console.ReadLine();
                    total = numbers.Sum();

                }
                Console.WriteLine("Sum of the number = " + total);
            }

        }
    }
}



