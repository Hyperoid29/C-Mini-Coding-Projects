using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Complex
{
    class Program
    {
        public static string username = "un";
        public static string password = "pw";

        private static readonly int lockout = 3;
        private static int attempts = 1;

        static void Main(string[] args)
        {
            Login();

            while (username != "un" || password!= "pw")
            {
                if (attempts != lockout)
                {
                    Console.WriteLine("Incorrect username or password");
                    Console.WriteLine($"Please Try Agin (Attempts: {attempts}/{lockout})");
                    attempts += 1;
                    Console.WriteLine(" ");
                    Login();
                }
                else
                {
                    Locked();

                    Console.WriteLine(" ");
                    Console.WriteLine("Please Be Patient");
                    Console.WriteLine("An Administrator Will Be With You Shortly ");
                    Console.ReadLine();
                }
            }
            if (username == "un" && password == "pw")
            {
                Console.WriteLine(" ");
                Console.WriteLine("Welcome");
                Console.WriteLine(" ");
                Console.WriteLine("Enter \'q\' to Quit ");
            }
            while (Console.Read() != 'q') ;
        }
        static void Login ()
        {
            Console.WriteLine("Enter You Username");
            username = Console.ReadLine();

            Console.WriteLine("Enter Your Password");
            password = Console.ReadLine();
      
        }
        static void Locked ()
        {
            Console.WriteLine("You Have Been Locked Out ");
            Console.WriteLine("Administrator Will Be Contacted ");
        }
    }
}
