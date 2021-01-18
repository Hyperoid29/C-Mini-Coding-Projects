using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departure_and_Arrival_System
{
    class Program
    {
        static string UInput = "";
       static string arrivalInput;
        static int Edinburgh, London, Glasgow, Manchester, Birmingham;
        const float edinburghLondon = 403.2f, edinburghGlasgow = 46.6f, edinburghManchester = 215.9f, edinburghBirmingham = 292.1f;
        static string EdWord = "Edinburgh";
        static string LoWord = "London";
        static string GlWord = "Glasgow";
        static string MaWord = "Manchester";
        static string BiWord = "Birmingham";
        static void Main(string[] args)
        {
            Console.WriteLine("Here is a list of cities, where do you want to go?");
            Header();
            Console.WriteLine("Edinburgh");
            Header();
            Console.WriteLine("London");
            Header();
            Console.WriteLine("Glasgow");
            Header();
            Console.WriteLine("Manchester");
            Header();
            Console.WriteLine("Birmingham");
            Header();
            Header();
            Console.Write("What is your departure? ");
            
            UInput = Console.ReadLine();
           
            Header();
            while (UInput == "")
            {
                Header();
                Console.WriteLine("Please input a valid input!");
                Console.Write("What is your departure time? ");
                UInput = Console.ReadLine();
            }
            whileLoopEd();

            Header();
            Console.Write("What is your arrival? ");
            arrivalInput = Console.ReadLine();
            while (arrivalInput == "")
            {
                Header();
                Console.WriteLine("Please input a valid input!");
                Console.Write("What is your arrival time? ");
                arrivalInput = Console.ReadLine();
            }
            
            if (UInput == "Edinburgh")
            {
               
            }
            else if (UInput == "London")
            {
            
            }
            else if (UInput == "Glasgow")
            {
                
            }
           else if (UInput == "Manchester")
            {
               
            }
          else if (UInput == "Birmingham")
            {
                
            }
            else
            {
                Console.WriteLine("Enter a valid input");
                Console.ReadLine();
            }
            Header();

            if (arrivalInput == "Edinburgh")
            {
              
            }
            else if (arrivalInput == "London")
            {
              
            }
            else if (arrivalInput == "Glasgow")
            {
               
            }
            else if (arrivalInput == "Manchester")
            {
               
            }
            else if (arrivalInput == "Birmingham")
            {
              
            }

            Console.WriteLine($"You have chosen {UInput} as your departure and {arrivalInput} as your arrival");

             if (UInput == "Edinburgh")
             {
                if (arrivalInput == "London")
                {
                    Console.WriteLine($"Edinburgh - London = approx 403.2 Miles ");
                    London = Int32.Parse(Console.ReadLine());
                }
                else if (arrivalInput == "Glasgow")
                {
                    Console.WriteLine("Edinburgh - Glasgow = approx 46.6 Miles ");
                    Glasgow = Int32.Parse(Console.ReadLine());
                }
                else if (arrivalInput == "Manchester")
                {
                    Console.WriteLine("Edinburgh - Manchester = approx 215.9 Miles ");
                    Manchester = Int32.Parse(Console.ReadLine());
                }
                else if (arrivalInput == "Birmingham")

                {
                    Console.WriteLine("Edinburgh - Birmingham = approx 292.1 Miles ");
                    Birmingham = Int32.Parse(Console.ReadLine());
                }
                Edinburgh = Int32.Parse(Console.ReadLine());
            }
            if (UInput == "London")
            {
                if (arrivalInput == "Edinburgh")
                {
                    Console.WriteLine($"London - Edinburgh = approx 403.2 Miles ");
                    London = Int32.Parse(Console.ReadLine());
                }
                else if (arrivalInput == "Glasgow")
                {
                    Console.WriteLine("London - Glasgow = approx 411.8 Miles ");
                    Glasgow = Int32.Parse(Console.ReadLine());
                }
                else if (arrivalInput == "Manchester")
                {
                    Console.WriteLine("London - Manchester = approx 208.5 Miles ");
                    Manchester = Int32.Parse(Console.ReadLine());
                }
                else if (arrivalInput == "Birmingham")

                {
                    Console.WriteLine("London - Birmingham = approx 125.7 Miles ");
                    Birmingham = Int32.Parse(Console.ReadLine());
                }
                London = Int32.Parse(Console.ReadLine());
            }
           if (UInput == "Glasgow")
            {

                if (arrivalInput == "Edinburgh")
                {
                    Console.WriteLine($"Glasgow - Edinburgh = approx 46.6 Miles ");
                    London = Int32.Parse(Console.ReadLine());
                }
                else if (arrivalInput == "London")
                {
                    Console.WriteLine("Glasgow - London = approx 411.8 Miles ");
                    Glasgow = Int32.Parse(Console.ReadLine());
                }
                else if (arrivalInput == "Manchester")
                {
                    Console.WriteLine("Glasgow - Manchester = approx 46.9 Miles ");
                    Manchester = Int32.Parse(Console.ReadLine());
                }
                else if (arrivalInput == "Birmingham")

                {
                    Console.WriteLine("Glasgow - Birmingham = approx 289.9 Miles ");
                    Birmingham = Int32.Parse(Console.ReadLine());
                }
                Glasgow = Int32.Parse(Console.ReadLine());

            }
           if (UInput == "Manchester")
            {
                if (arrivalInput == "Edinburgh")
                {
                    Console.WriteLine($"Manchester - Edinburgh = approx 215.9 Miles ");
                    London = Int32.Parse(Console.ReadLine());
                }
                else if (arrivalInput == "London")
                {
                    Console.WriteLine("Manchester - London = approx 208.5 Miles ");
                    Glasgow = Int32.Parse(Console.ReadLine());
                }
                else if (arrivalInput == "Glasgow")
                {
                    Console.WriteLine("Manchester - Glasgow = approx 46.9 Miles ");
                    Manchester = Int32.Parse(Console.ReadLine());
                }
                else if (arrivalInput == "Birmingham")

                {
                    Console.WriteLine("Manchester - Birmingham = approx 86.6 Miles ");
                    Birmingham = Int32.Parse(Console.ReadLine());
                }
                Manchester = Int32.Parse(Console.ReadLine());

            }
           if (UInput == "Birmingham")
            {
                if (arrivalInput == "Edinburgh")
                {
                    Header();
                    Console.WriteLine($"Birmingham - Edinburgh = approx 292.1 Miles ");
                    London = Int32.Parse(Console.ReadLine());
                }
                else if (arrivalInput == "London")
                {
                    Header();
                    Console.WriteLine("Birmingham - London = approx 125.7 Miles ");
                    Glasgow = Int32.Parse(Console.ReadLine());
                }
                else if (arrivalInput == "Glasgow")
                {
                    Header();
                    Console.WriteLine("Birmingham - Glasgow = approx 289.9 Miles ");
                    Manchester = Int32.Parse(Console.ReadLine());
                }
                else if (arrivalInput == "Manchester")
                {
                    Header();
                    Console.WriteLine("Birmingham - Manchester = approx 86.6 Miles ");
                    Birmingham = Int32.Parse(Console.ReadLine());
                }
                Birmingham = Int32.Parse(Console.ReadLine());
                }
                else
                {
                    Header();
                    Console.WriteLine("Enter a valid input");
                    Console.ReadLine();
                }
                Header();
            Console.ReadLine();
        }
        private static void Header()
        {
            Console.WriteLine("---------------------------");
        }
        private static void whileLoopEd()
        {
            while (UInput != EdWord)
            {
                Console.WriteLine("Enter a valid string");
                Console.ReadLine();
            }

            //while (UInput != LoWord)
            //{
            //    Console.WriteLine("Enter a valid string");
            //    UInput = Console.ReadLine();
            //}
            // while (UInput != GlWord)
            // {
            //    Console.WriteLine("Enter a valid string");
            //    UInput = Console.ReadLine();
            //}


            // while (UInput != MaWord)
            //{
            //    Console.WriteLine("Enter a valid string");
            //    UInput = Console.ReadLine();
            //}

            // while (UInput != BiWord)
            //{
            //    Console.WriteLine("Enter a valid string");
            //    UInput = Console.ReadLine();
            //}

        }
    }
}
