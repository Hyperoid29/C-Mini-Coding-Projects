using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace How_many_ants_are_you_tall
{
    class Program
    {
        static void Main(string[] args)
        {
            const float antHeight = 0.35f;
            float userHeight = 0.0f;
            float Distance = 0.0f;
           

            double dblAnt = 0.0f;

            Console.WriteLine("How tall are you in cm?!");
            Console.WriteLine("Fact: Ants are approx 3.5mm tall");
            userHeight = float.Parse(Console.ReadLine());

            if (userHeight > antHeight)
            {
                Distance = userHeight - antHeight;
                Console.WriteLine($"You are this {Distance} cm taller than an ant!");
                dblAnt = Math.Round(Distance, 2);
                dblAnt = userHeight / antHeight;
                Console.WriteLine($"That is approx the height of {dblAnt} ants!");
            }
            else if (userHeight < antHeight)
            {
                Distance = antHeight - userHeight;
                Console.WriteLine($"You are {Distance} cm smaller than an average ant height! ");
                Console.WriteLine($"You are smaller than an ant!");
            }
            else if (userHeight == antHeight)
            {
                Distance = 0.0f;
               
                Console.WriteLine("You are the exact height of an ant!");
                Console.WriteLine("That is approx the height of 1 ant!");
            }
            
          
            Console.ReadLine();
        }
    }
}
