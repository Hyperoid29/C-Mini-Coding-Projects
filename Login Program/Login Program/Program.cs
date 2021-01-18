using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string UserID = "";
            string UserPW = "";
            int guessCount = 0;
            int guessLimit = 5;
            bool outOfGuesses = false;

            while (UserID != "un" && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("Enter UserName?!");
                    UserID = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
               
            }
         
            while (UserPW != "pw" && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("Enter Password?!");
                    UserPW = Console.ReadLine();
                    guessCount++;
                }

                else
                {
                    outOfGuesses = true;
                }
                
            }
            if (outOfGuesses)
            {
                Console.WriteLine("Account timed out!");
                Console.WriteLine("Administor will be with you shortly");
            }
            else
            {
                Console.WriteLine("You have successfully logged into your account!");
            }
           

            Console.ReadLine();
        }
    }
}
