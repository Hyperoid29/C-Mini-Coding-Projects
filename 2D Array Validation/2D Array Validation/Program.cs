using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Array_Validation
{
    class Program
    {
        static int[,] arrDays = new int[5, 1];
        static string NumberAsAString;
        static int gradeUsers;
        static int User;
        static void Main(string[] args)
        {
            Console.WriteLine("What is your grade markout of 100?! Only 5 can be inputted");
            Header();
   
            for (int i = 0; i < arrDays.GetLength(0); i++)
            {
                for (int j = 0; j < arrDays.GetLength(1); j++)
                {
                    gradeUsers = gradeUsers + 1;
                    Console.WriteLine($"Whats the grade for the {gradeUsers} user");
                    NumberAsAString = Console.ReadLine();

                   

                    Header();
                   
                    Header();
                    while (!int.TryParse(NumberAsAString, out arrDays[i, j]))
                    { 
                        Console.WriteLine("Error, please input an integer");
                        Console.WriteLine("Please enter a valid answer");
                        NumberAsAString = Console.ReadLine();
                    }
                    while (arrDays[i, j] < 0)
                    {
                        Console.WriteLine("You have gone under the limit");
                        Console.WriteLine("Enter a number between 1-20");
                       
                        while (!int.TryParse(NumberAsAString, out arrDays[i, j]))
                        {
                            Console.WriteLine("Error, please input an integer");
                            Console.WriteLine("Please enter a valid answer");
                            NumberAsAString = Console.ReadLine();
                        }
                        arrDays[i, j] = Int32.Parse(Console.ReadLine());
                    }
                    while (arrDays[i, j] > 60)
                    {
                        Console.WriteLine("You have gone over the limit");
                        Console.WriteLine("Enter a number between 1-20");
                        
                        while (!int.TryParse(NumberAsAString, out arrDays[i, j]))
                        {
                            Console.WriteLine("Error, please input an integer");
                            Console.WriteLine("Please enter a valid answer");
                            NumberAsAString = Console.ReadLine();
                        }
                        arrDays[i, j] = Int32.Parse(Console.ReadLine());
                    }
                    if (arrDays[i, j] >= 48)
                    {
                        Console.WriteLine("This student has earned a grade of a Distinction, well done");
                    }
                    else if (arrDays[i, j] >= 36)
                    {
                        Console.WriteLine("This student has achieved a grade Merit, well done");
                    }
                    else if (arrDays[i, j] >= 19)
                    {
                        Console.WriteLine("This student has achieved a grade Pass, well done");
                    }
                    else if (arrDays[i, j] <= 18)
                    {
                        Console.WriteLine("This student has achieved a grade of an unclassified");
                    }
                }
            }
            for (int i = 0; i < arrDays.GetLength(0); i++)
            {
                for (int j = 0; j < arrDays.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                       User = User + 1;
                        Header();
                        Console.WriteLine($"Person {User} has got {arrDays[i, j]}  ");
                        Header();
                    }
                }
            }
            Console.ReadLine();
        }
        private static void Header()
        {
            Console.WriteLine("-------------------------");
        }
     
    }
}
