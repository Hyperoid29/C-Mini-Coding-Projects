using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earning_fora_week__month_or_year
{
    class Program
    {
        static string FName;
        static string SName;
        static int Week;
        static int Month;
        static int Year;
        static float _userEarning;
        static string Time;
        static int Hour;
        static int Days;
        static void Main(string[] args)
        {
            Header();

            Console.WriteLine("What is your first name?");
            FName = Console.ReadLine();
            Header();

            Console.WriteLine("What is your second name?");
            SName = Console.ReadLine();

            Header();

            Console.WriteLine($"{FName} {SName} whats your earnings an hour in pounds (£)?");
            _userEarning = float.Parse(Console.ReadLine());
            Header();
            Console.WriteLine($"{FName} {SName} How many hours do you work in a day?");
            Hour = Int32.Parse(Console.ReadLine());
            Header();
            Console.WriteLine($"{FName} {SName} How many days do you work in a week?");
            Days = Int32.Parse(Console.ReadLine());
            Header();

            Console.WriteLine($"{FName} {SName} do you want to check how much you earn in a week, month or year? (type 'W' week, 'M' for month and 'Y' for year)");
            Time = Console.ReadLine();

            if (char.Parse(Time) == 'W')
            {
                Header();
                Console.WriteLine("You have chosen weeks!");
                Console.WriteLine(Calc(Time, Hour, Days, _userEarning));
                Week = Int32.Parse(Console.ReadLine());
           
            }
            else if (char.Parse(Time) == 'M')
            {
                Header();
                Console.WriteLine("You have chosen months!");
                Console.WriteLine(Calc(Time, Hour, Days, _userEarning));
                Month = Int32.Parse(Console.ReadLine());
           
            }
            else if (char.Parse(Time) == 'Y')
            {
                Header();
                Console.WriteLine("You have chosen year!");
                Console.WriteLine(Calc(Time, Hour, Days, _userEarning));
                Year = Int32.Parse(Console.ReadLine());
                
            }

            Console.WriteLine(Calc(Time, Hour, Days, _userEarning));

            Console.ReadLine();
        }
        private static float Calc(string Time, int Hour, int Days, float _userEarning)
            {
            float answer = 0.0f;
            if (Time == "W")
            {
                answer = (_userEarning * Hour) * Days;
            }
            else if (Time == "M")
            {
                answer = (_userEarning * Hour) *  Days * 4;
            }
            else if (Time == "Y")
                {
                answer = (_userEarning * Hour) * Days * 52;
            }
           
            Console.WriteLine($"{FName} {SName} your answer is: £");
            Header();
            return answer;
            }
        private static void Header()
        {
            Console.WriteLine("------------------------------------");
        }
    }
}
