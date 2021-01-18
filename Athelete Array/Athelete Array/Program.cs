using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Athelete_Array
{
    class Program
    {
        const float MenWorldRec = 9.58f, MenEuroRec = 9.86f, MenBritRec = 9.87f, WomanWorldRec = 10.49f, WomanEuroRec = 10.73f, WomanBritRec = 10.99f;
        static string UInput;
        static float[] arrAthlete4 = new float[4], arrAthlete5 = new float[5], arrAthlete6 = new float[6], arrAthlete7 = new float[7], arrAthlete8 = new float[8];
        static int theNumberAsAnInt, AmountofAthletes;
        
        static void Main(string[] args)
        {
            Console.WriteLine("Does the race involve a male or female? Type 'Male' / 'Female' in order to execute the program");
            UInput = Console.ReadLine();
            while (UInput == "")
            {
                Console.WriteLine("You must enter a valid string!");
                Console.ReadLine();
                Console.Clear();
                Validation();
                tryParse();
            }

            Console.WriteLine("How many athletes do you want to input?");
            AmountofAthletes = Int32.Parse(Console.ReadLine());

            while (AmountofAthletes < 3)
            {
                Console.WriteLine("Cannot input less than the minimum athletes");
                Console.ReadLine();
                Console.Clear();
                Validation();
                tryParse();
            }

            if (UInput == "Male")
            {
                MandF();
                if (AmountofAthletes == 4)
                for (int i = 0; i < arrAthlete4.Length; i++)
                {
                    Console.WriteLine("Enter Athlete Race Time");
                    arrAthlete4[i] = float.Parse(Console.ReadLine());
                        if (arrAthlete4[i] < 9.58)
                        {
                           
                            Console.WriteLine("Congratulations, you have broken the world record!");
                            Header();
                        }
                        else if (arrAthlete4[i] == 9.58)
                        {
                            
                            Console.WriteLine("You have the same time as a world record holder!");
                            Header();
                        }
                        else if (arrAthlete4[i] < 9.86)
                        {
                           
                            Console.WriteLine("Congratulations, you have beaten the European Record Time!");
                            Header();

                        }
                        else if (arrAthlete4[i] == 9.86)
                        {
                           
                            Console.WriteLine("You have the same time as a European Record Holder!");
                            Header();

                        }
                        else if (arrAthlete4[i] < 9.87)
                        {
                            
                            Console.WriteLine("You have broken the British Record Time!");
                            Header();

                        }
                        else if (arrAthlete4[i] == 9.87)
                        {
                            Console.WriteLine("You have the same time as a British Record Time holder!");
                            Header();

                        }
                        else if (arrAthlete4[i] > 9.88)
                        {
                            
                            Console.WriteLine("You have not achieved any of the record times, sorry LMAO!");
                            Header();
                        }


                    }
                if (AmountofAthletes == 5)
                    for (int i = 0; i < arrAthlete5.Length; i++)
                    {
                        Console.WriteLine("Enter Athlete Race Time");
                        arrAthlete5[i] = float.Parse(Console.ReadLine());
                        if (arrAthlete5[i] < 9.58)
                        {
                           
                            Console.WriteLine("Congratulations, you have broken the world record!");
                            Header();
                        }
                         else if (arrAthlete5[i] == 9.58)
                        {
                           
                            Console.WriteLine("You have the same time as a world record holder!");
                            Header();
                        }
                        else if (arrAthlete5[i] < 9.86)
                        {
                            
                            Console.WriteLine("Congratulations, you have beaten the European Record Time!");
                            Header();

                        }
                        else if (arrAthlete5[i] == 9.86)
                        {
                           
                            Console.WriteLine("You have the same time as a European Record Holder!");
                            Header();
                        }
                        else if (arrAthlete5[i] < 9.87)
                        {
                           
                            Console.WriteLine("You have broken the British Record Time!");
                            Header();
                        }
                        else if (arrAthlete5[i] == 9.87)
                        {
                            
                            Console.WriteLine("You have the same time as a British Record Time holder!");
                            Header();
                        }
                        else if (arrAthlete5[i] > 9.88)
                        {
                           
                            Console.WriteLine("You have not achieved any of the record times, sorry LMAO!");
                            Header();
                        }
                       

                    }
                if (AmountofAthletes == 6)
                    for (int i = 0; i < arrAthlete6.Length; i++)
                    {
                        Console.WriteLine("Enter Athlete Race Time");
                        arrAthlete6[i] = float.Parse(Console.ReadLine());
                        if (arrAthlete6[i] < 9.58)
                        {
                           
                            Console.WriteLine("Congratulations, you have broken the world record!");
                            Header();
                        }
                        else if (arrAthlete6[i] == 9.58)
                        {
                            Console.WriteLine("You have the same time as a world record holder!");
                            Header();
                        }
                        else if (arrAthlete6[i] < 9.86)
                        {
                           
                            Console.WriteLine("Congratulations, you have beaten the European Record Time!");
                            Header();
                        }
                        else if (arrAthlete6[i] == 9.86)
                        {
                           
                            Console.WriteLine("You have the same time as a European Record Holder!");
                            Header();
                        }
                        else if (arrAthlete6[i] < 9.87)
                        {
                            
                            Console.WriteLine("You have broken the British Record Time!");
                            Header();
                        }
                        else if (arrAthlete6[i] == 9.87)
                        {
                           
                            Console.WriteLine("You have the same time as a British Record Time holder!");
                            Header();
                        }
                        else if (arrAthlete6[i] > 9.88)
                        {
                            Console.WriteLine("You have not achieved any of the record times, sorry LMAO!");
                            Header();
                        }


                    }
                if (AmountofAthletes == 7)
                    for (int i = 0; i < arrAthlete7.Length; i++)
                    {
                        Console.WriteLine("Enter Athlete Race Time");
                        arrAthlete7[i] = float.Parse(Console.ReadLine());
                        if (arrAthlete7[i] < 9.58)
                        {
                         
                            Console.WriteLine("Congratulations, you have broken the world record!");
                            Header();
                        }
                        else if (arrAthlete7[i] == 9.58)
                        { 
                           
                            Console.WriteLine("You have the same time as a world record holder!");
                            Header();
                        }
                        else if (arrAthlete7[i] < 9.86)
                        {
                            
                            Console.WriteLine("Congratulations, you have beaten the European Record Time!");
                            Header();
                        }
                        else if (arrAthlete7[i] == 9.86)
                        {
                           
                            Console.WriteLine("You have the same time as a European Record Holder!");
                            Header();
                        }
                        else if (arrAthlete7[i] < 9.87)
                        {
                            
                            Console.WriteLine("You have broken the British Record Time!");
                            Header();
                        }
                        else if (arrAthlete7[i] == 9.87)
                        {
                            
                            Console.WriteLine("You have the same time as a British Record Time holder!");
                            Header();
                        }
                        else if (arrAthlete7[i] > 9.88)
                        {
                           
                            Console.WriteLine("You have not achieved any of the record times, sorry LMAO!");
                            Header();
                        }


                    }
                if (AmountofAthletes == 8)
                    for (int i = 0; i < arrAthlete8.Length; i++)
                    {
                        Console.WriteLine("Enter Athlete Race Time");
                        arrAthlete8[i] = float.Parse(Console.ReadLine());
                        if (arrAthlete8[i] < 9.58)
                        {
                           
                            Console.WriteLine("Congratulations, you have broken the world record!");
                            Header();
                        }
                        else if (arrAthlete8[i] == 9.58)
                        {
                            
                            Console.WriteLine("You have the same time as a world record holder!");
                            Header();
                        }
                        else if (arrAthlete8[i] < 9.86)
                        {
                           
                            Console.WriteLine("Congratulations, you have beaten the European Record Time!");
                            Header();

                        }
                        else if (arrAthlete8[i] == 9.86)
                        {
                         
                            Console.WriteLine("You have the same time as a European Record Holder!");
                            Header();

                        }
                        else if (arrAthlete8[i] < 9.87)
                        {
                           
                            Console.WriteLine("You have broken the British Record Time!");
                            Header();

                        }
                        else if (arrAthlete8[i] == 9.87)
                        {
                            Console.WriteLine("You have the same time as a British Record Time holder!");
                            Header();
                        }
                        else if (arrAthlete8[i] > 9.88)
                        {
                            Console.WriteLine("You have not achieved any of the record times, sorry LMAO!");
                            Header();
                        }


                    }

            }

            else if (UInput == "Female")
            {
                MandF();
                if (AmountofAthletes == 4)
                for (int i = 0; i < arrAthlete4.Length; i++)
                {
                    Console.WriteLine("Enter Athlete Race Time");
                    arrAthlete4[i] = float.Parse(Console.ReadLine());
                        if (arrAthlete4[i] < 10.49)
                        {
                            Console.WriteLine("Congratulations, you have broken the world record!");
                            Header();
                        }
                        else if (arrAthlete4[i] == 10.49)
                        {
                            Console.WriteLine("You have the same time as a world record holder!");

                            Header();
                        }
                        else if (arrAthlete4[i] < 10.73)
                        {
                            Console.WriteLine("Congratulations, you have beaten the European Record Time!");
                            Header();
                        }
                        else if (arrAthlete4[i] == 10.73)
                        {
                            Console.WriteLine("You have the same time as a European Record Holder!");
                            Header();
                        }
                        else if (arrAthlete4[i] < 10.99)
                        {
                            Console.WriteLine("You have broken the British Record Time!");
                            Header();
                        }
                        else if (arrAthlete4[i] == 10.99)
                        {
                            Console.WriteLine("You have the same time as a British Record Time holder!");
                            Header();
                        }
                        else if (arrAthlete4[i] > 11)
                        {
                            Console.WriteLine("You have not achieved any of the record times, sorry LMAO!");
                            Header();
                        }

                    }
                if (AmountofAthletes == 5)
                    for (int i = 0; i < arrAthlete5.Length; i++)
                    {
                        Console.WriteLine("Enter Athlete Race Time");
                        arrAthlete5[i] = float.Parse(Console.ReadLine());
                        if (arrAthlete5[i] < 10.49)
                        {
                            Console.WriteLine("Congratulations, you have broken the world record!");
                            Header();
                        }
                        else if (arrAthlete5[i] == 10.49)
                        {
                            Console.WriteLine("You have the same time as a world record holder!");
                            Header();

                        }
                        else if (arrAthlete5[i] < 10.73)
                        {
                            Console.WriteLine("Congratulations, you have beaten the European Record Time!");
                            Header();
                        }
                        else if (arrAthlete5[i] == 10.73)
                        {
                            Console.WriteLine("You have the same time as a European Record Holder!");
                            Header();
                        }
                        else if (arrAthlete5[i] < 10.99)
                        {
                            Console.WriteLine("You have broken the British Record Time!");
                            Header();
                        }
                        else if (arrAthlete5[i] == 10.99)
                        {
                            Console.WriteLine("You have the same time as a British Record Time holder!");
                            Header();
                        }
                        else if (arrAthlete5[i] > 11)
                        {
                            Console.WriteLine("You have not achieved any of the record times, sorry LMAO!");
                            Header();
                        }

                    }
                if (AmountofAthletes == 6)
                    for (int i = 0; i < arrAthlete6.Length; i++)
                    {
                        Console.WriteLine("Enter Athlete Race Time");
                        arrAthlete6[i] = float.Parse(Console.ReadLine());
                        if (arrAthlete6[i] < 10.49)
                        {
                            Console.WriteLine("Congratulations, you have broken the world record!");
                            Header();
                        }
                        else if (arrAthlete6[i] == 10.49)
                        {
                            Console.WriteLine("You have the same time as a world record holder!");

                            Header();
                        }
                        else if (arrAthlete6[i] < 10.73)
                        {
                            Console.WriteLine("Congratulations, you have beaten the European Record Time!");
                            Header();
                        }
                        else if (arrAthlete6[i] == 10.73)
                        {
                            Console.WriteLine("You have the same time as a European Record Holder!");
                            Header();
                        }
                        else if (arrAthlete6[i] < 10.99)
                        {
                            Console.WriteLine("You have broken the British Record Time!");
                            Header();
                        }
                        else if (arrAthlete6[i] == 10.99)
                        {
                            Console.WriteLine("You have the same time as a British Record Time holder!");
                            Header();
                        }
                        else if (arrAthlete6[i] > 11)
                        {
                            Console.WriteLine("You have not achieved any of the record times, sorry LMAO!");
                            Header();
                        }

                    }
                if (AmountofAthletes == 7)
                    for (int i = 0; i < arrAthlete7.Length; i++)
                    {
                        Console.WriteLine("Enter Athlete Race Time");
                        arrAthlete7[i] = float.Parse(Console.ReadLine());
                        if (arrAthlete7[i] < 10.49)
                        {
                            Console.WriteLine("Congratulations, you have broken the world record!");
                            Header();
                        }
                        else if (arrAthlete7[i] == 10.49)
                        {
                            Console.WriteLine("You have the same time as a world record holder!");
                            Header();

                        }
                        else if (arrAthlete7[i] < 10.73)
                        {
                            Console.WriteLine("Congratulations, you have beaten the European Record Time!");
                            Header();
                        }
                        else if (arrAthlete7[i] == 10.73)
                        {
                            Console.WriteLine("You have the same time as a European Record Holder!");
                            Header();
                        }
                        else if (arrAthlete7[i] < 10.99)
                        {
                            Console.WriteLine("You have broken the British Record Time!");
                            Header();
                        }
                        else if (arrAthlete7[i] == 10.99)
                        {
                            Console.WriteLine("You have the same time as a British Record Time holder!");
                            Header();
                        }
                        else if (arrAthlete7[i] > 11)
                        {
                            Console.WriteLine("You have not achieved any of the record times, sorry LMAO!");
                            Header();
                        }
                    }
                if (AmountofAthletes == 8)
                    for (int i = 0; i < arrAthlete8.Length; i++)
                    {
                        Console.WriteLine("Enter Athlete Race Time");
                        arrAthlete8[i] = float.Parse(Console.ReadLine());
                        if (arrAthlete8[i] < 10.49)
                        {
                            Console.WriteLine("Congratulations, you have broken the world record!");
                            Header();
                        }
                        else if (arrAthlete8[i] == 10.49)
                        {
                            Console.WriteLine("You have the same time as a world record holder!");
                            Header();

                        }
                        else if (arrAthlete8[i] < 10.73)
                        {
                            Console.WriteLine("Congratulations, you have beaten the European Record Time!");
                            Header();
                        }
                        else if (arrAthlete8[i] == 10.73)
                        {
                            Console.WriteLine("You have the same time as a European Record Holder!");
                            Header();
                        }
                        else if (arrAthlete8[i] < 10.99)
                        {
                            Console.WriteLine("You have broken the British Record Time!");
                            Header();
                        }
                        else if (arrAthlete8[i] == 10.99)
                        {
                            Console.WriteLine("You have the same time as a British Record Time holder!");
                            Header();
                        }
                        else if (arrAthlete8[i] > 11)
                        {
                            Console.WriteLine("You have not achieved any of the record times, sorry LMAO!");
                            Header();
                        }
                    }
            }

            Array.Sort(arrAthlete4);
            Array.Reverse(arrAthlete4);
            Array.Sort(arrAthlete5);
            Array.Reverse(arrAthlete5);
            Array.Sort(arrAthlete6);
            Array.Reverse(arrAthlete6);
            Array.Sort(arrAthlete7);
            Array.Reverse(arrAthlete7);
            Array.Sort(arrAthlete8);
            Array.Reverse(arrAthlete8);

            for (int i = 0; i < arrAthlete4.Length; i++)
            {
                //Console.WriteLine($" The student has achieved: {arrAthlete[i]}");
                if (AmountofAthletes == 4)
                {
                    Header();
                    Console.WriteLine("These are the times of the chosen participants");
                    Header();
                  
                    Console.WriteLine("Slowest");
                    Console.WriteLine(arrAthlete4[0] + " seconds");
                    Console.WriteLine(arrAthlete4[1] + " seconds");
                    Console.WriteLine(arrAthlete4[2] + " seconds");
                    Console.WriteLine(arrAthlete4[3] + " seconds");
                    Console.WriteLine("Fastest");
                }
                if (AmountofAthletes == 5)
                {
                    Header();
                    Console.WriteLine("These are the times of the chosen participants");
                    Header();
                    Console.WriteLine("Slowest");
                    Console.WriteLine(arrAthlete5[0] + " seconds");
                    Console.WriteLine(arrAthlete5[1] + " seconds");
                    Console.WriteLine(arrAthlete5[2] + " seconds");
                    Console.WriteLine(arrAthlete5[3] + " seconds");
                    Console.WriteLine(arrAthlete5[4] + " seconds");
                    Console.WriteLine("Fastest");
                }
               if (AmountofAthletes == 6)
                {
                    Header();
                    Console.WriteLine("These are the times of the chosen participants");
                    Header();
                    Console.WriteLine("Slowest");
                    Console.WriteLine(arrAthlete6[0] + " seconds");
                    Console.WriteLine(arrAthlete6[1] + " seconds");
                    Console.WriteLine(arrAthlete6[2] + " seconds");
                    Console.WriteLine(arrAthlete6[3] + " seconds");
                    Console.WriteLine(arrAthlete6[4] + " seconds");
                    Console.WriteLine(arrAthlete6[5] + " seconds");
                    Console.WriteLine("Fastest");
                }
               if (AmountofAthletes == 7)
                {
                    Header();
                    Console.WriteLine("These are the times of the chosen participants");
                    Header();
                    Console.WriteLine("Slowest");
                    Console.WriteLine(arrAthlete7[0] + " seconds");
                    Console.WriteLine(arrAthlete7[1] + " seconds");
                    Console.WriteLine(arrAthlete7[2] + " seconds");
                    Console.WriteLine(arrAthlete7[3] + " seconds");
                    Console.WriteLine(arrAthlete7[4] + " seconds");
                    Console.WriteLine(arrAthlete7[5] + " seconds");
                    Console.WriteLine(arrAthlete7[6] + " seconds");
                    Console.WriteLine("Fastest");
                }
               if (AmountofAthletes == 8)
                {
                    Header();
                    Console.WriteLine("These are the times of the chosen participants");
                    Header();
                    Console.WriteLine("Slowest");
                    Console.WriteLine(arrAthlete8[0] + " seconds");
                    Console.WriteLine(arrAthlete8[1] + " seconds");
                    Console.WriteLine(arrAthlete8[2] + " seconds");
                    Console.WriteLine(arrAthlete8[3] + " seconds");
                    Console.WriteLine(arrAthlete8[4] + " seconds");
                    Console.WriteLine(arrAthlete8[5] + " seconds");
                    Console.WriteLine(arrAthlete8[6] + " seconds");
                    Console.WriteLine(arrAthlete8[7] + " seconds");
                    Console.WriteLine("Fastest");
                }
                AmountofAthletes = Int32.Parse(Console.ReadLine());
            }

           
            



            Console.ReadLine();
        }
        private static void tryParse()
        {
            while (Int32.TryParse(UInput, out theNumberAsAnInt))
            {
                Console.WriteLine("Please input a string");
                Console.WriteLine("Does the race involve a male or female? Type 'Male' / 'Female' in order to execute the program");
                UInput = Console.ReadLine();
            }
        }
        private static void Validation()
        {
            Console.WriteLine("Does the race involve a male or female? Type 'Male' / 'Female' in order to execute the program");
            UInput = Console.ReadLine();
        }
        private static void MandF()
        {
            if (UInput == "Male")
            {
                Header();
                Console.WriteLine("World Record Time: " + MenWorldRec);
                Header();
                Console.WriteLine("European Record Time: " + MenEuroRec);
                Header();
                Console.WriteLine("British Record Time: " + MenBritRec);
                Header();



            }
            else if (UInput == "Female")
            {
                Console.WriteLine("World Record Time: " + WomanWorldRec);
                Header();
                Console.WriteLine("European Record Time: " + WomanEuroRec);
                Header();
                Console.WriteLine("British Record Time: " + WomanBritRec);
                Header();

            }
            else
            {
                Console.WriteLine("Please input a valid string");
                Console.ReadLine();
            }

        }
        private static void Header()
        {
            Console.WriteLine("-----------------------------");
        }
    }
}
