using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionaire
{
    class Program
    {
        static string uStart;
        static int userMoney = 1, Utotal;
        static char uInput;


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the question problem");
            Console.WriteLine("There are 5 question which you would need to answer and you only have 3 tries in order to get them correct");
            Console.WriteLine("Press 'enter' in order to start the question");
            uStart = Console.ReadLine();
            Header();
           
            Console.WriteLine("(1) How many planets are there in the solar system?");
            Console.WriteLine(" ");
            Header();
            Console.WriteLine("(A) 8");
            Header();
            Console.WriteLine("(B) 9");
            Header();
            Console.WriteLine("(C) 10");
            Header();
            Console.WriteLine("(D) 6");
            uInput = Char.Parse(Console.ReadLine());

            if (uInput == 'A')
            {
                Header();
                Console.WriteLine("You have gotten the answer CORRECT, well done");
                Utotal = userMoney * 100;
                Header();
                Console.WriteLine("Your total money: " + "£"+Utotal);
                Console.WriteLine("Press 'enter' in order to recieve the next question! ");
                Header();
                uStart = Console.ReadLine();

                Console.WriteLine("(2) Who is the prime minister of the UK");
                Console.WriteLine(" ");
                Header();
                Console.WriteLine("(A) Barack Obama");
                Header();
                Console.WriteLine("(B) Donald Trump");
                Header();
                Console.WriteLine("(C) Theresa May");
                Header();
                Console.WriteLine("(D) George Bush");
                uInput = Char.Parse(Console.ReadLine());

                if (uInput == 'A')
                {
                    Console.WriteLine("You have gotten the answer WRONG, you have lost one life");
                

                }
                else if (uInput == 'B')
                {
                    Console.WriteLine("You have gotten the answer WRONG, you have lost one life");
                }
                else if (uInput == 'C')
                {
                    Header();
                    Console.WriteLine("You have gotten the answer CORRECT, well done");
                    Header();
                    Utotal = userMoney * 500;
                    Console.WriteLine("Your total money: " + "£" + Utotal);
                    Console.WriteLine("Press 'enter' in order to recieve the next question! ");
                    Header();
                    uStart = Console.ReadLine();
            
         

                  
                    Console.WriteLine("(3) How many sides does a decagon have?");
                    Console.WriteLine(" ");
                    Header();
                    Console.WriteLine("(A) 12");
                    Header();
                    Console.WriteLine("(B) 15");
                    Header();
                    Console.WriteLine("(C) 20");
                    Header();
                    Console.WriteLine("(D) 10");
                    uInput = Char.Parse(Console.ReadLine());

                    if (uInput == 'A')
                    {
                        Console.WriteLine("You have gotten the answer WRONG, you have lost one life");
                    }
                  else if (uInput == 'B')
                    {
                        Console.WriteLine("You have gotten the answer WRONG, you have lost one life");
                    }
                  else  if (uInput == 'C')
                    {
                        Console.WriteLine("You have gotten the answer WRONG, you have lost one life");
                    }
                  else  if (uInput == 'D')
                    {
                        Console.WriteLine("You have gotten the answer CORRECT, well done");
                        Utotal = userMoney * 5000;
                        Console.WriteLine("Your total money: " + "£" + Utotal);
                        Console.WriteLine("Press 'enter' in order to recieve the next question! ");
                        uStart = Console.ReadLine();

                        Console.WriteLine("(4) What country is Budapest located at ?");
                        Console.WriteLine(" ");
                        Header();
                        Console.WriteLine("(A) Hungary");
                        Header();
                        Console.WriteLine("(B) Poland");
                        Header();
                        Console.WriteLine("(C) Italy");
                        Header();
                        Console.WriteLine("(D) Serbia");
                        uInput = Char.Parse(Console.ReadLine());


                        if (uInput == 'A')
                        {
                            Console.WriteLine("You have gotten the answer CORRECT, well done");
                            Utotal = userMoney * 7500;
                            Console.WriteLine("Your total money: " + "£" + Utotal);
                            Console.WriteLine("Press 'enter' in order to recieve the next question! ");
                            uStart = Console.ReadLine();


                            Console.WriteLine("(5) How many Apollo missions landed men on the moon?  ?");
                            Console.WriteLine(" ");
                            Header();
                            Console.WriteLine("(A) 2");
                            Header();
                            Console.WriteLine("(B) 5");
                            Header();
                            Console.WriteLine("(C) 6");
                            Header();
                            Console.WriteLine("(D) 9");
                            uInput = Char.Parse(Console.ReadLine());
                            if (uInput == 'A')
                            {
                                Console.WriteLine("You have gotten the answer WRONG, you have lost one life");
                            }
                            else if (uInput == 'B')
                            {
                                Console.WriteLine("You have gotten the answer WRONG, you have lost one life");
                            }
                            else if (uInput == 'C')
                            {
                                Console.WriteLine("You have gotten the answer CORRECT, well done");
                                Utotal = userMoney * 10000;
                                Console.WriteLine("Your total money: " + "£" + Utotal);
                                Console.WriteLine("Congratulations, you have got all of the questions correct and recieved £10,000");
                                Quit();
                            }
                            else if (uInput == 'D')
                            {
                                Console.WriteLine("You have gotten the answer WRONG, you have lost one life");
                            }



                        }
                        else if (uInput == 'B')
                        {
                            Console.WriteLine("You have gotten the answer WRONG, you have lost one life");
                        }
                        else if (uInput == 'C')
                        {
                            Console.WriteLine("You have gotten the answer WRONG, you have lost one life");
                        }
                        else if (uInput == 'D')
                        {
                            Console.WriteLine("You have gotten the answer WRONG, you have lost one life");
                        }
                    }


                  
                 


                }
                else if (uInput == 'D')
                {
                    Console.WriteLine("You have gotten the answer WRONG, you have lost one life");
                }
                else
                {
                    Console.WriteLine("Please type in correct value");
                    uStart = Console.ReadLine();
                }

            }









            else if (uInput == 'B')
            {
                Console.WriteLine("You have gotten the answer WRONG, you have lost one life");
            }
            else if (uInput == 'C')
            {
                Console.WriteLine("You have gotten the answer WRONG, you have lost one life");
            }
            else if (uInput == 'D')
            {
                Console.WriteLine("You have gotten the answer WRONG, you have lost one life");
            }


            Console.ReadLine();
        }
        private static void Header()
        {
            Console.WriteLine("------------------------------------");
        }
        private static void Quit()
        {
            Console.WriteLine("Press /'q'/ in order to quit the program.");
        }
    }
}
