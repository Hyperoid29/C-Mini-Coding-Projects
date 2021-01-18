using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easter_Mock_2019
{
    class Program
    {
        static double UInput, Answer;
        static int userCurrency;
        static float[] arrConversion = new float[5];
        static void Main(string[] args)
        {
            Console.WriteLine("What is the amount you want to convert (£)?!");
            UInput = float.Parse(Console.ReadLine());

            Console.WriteLine("Select you capacity (1-5)");
            Header();
            Console.WriteLine("(1) American Dollars (USD)");
            Header();
            Console.WriteLine("(2) Euros (EUR)");
            Header();
            Console.WriteLine("(3) Brazilian Real (BRL)");
            Header();
            Console.WriteLine("(4) Japanese Yen (JPY)");
            Header();
            Console.WriteLine("(5) Turkish Lira (TRY)");
            Header();
            Header();
            userCurrency = Int32.Parse(Console.ReadLine());

            if(userCurrency == 1)
            {
                Console.WriteLine("You have chosen American Dollars");
                Header();
                Console.WriteLine("Exchange Rates");
                Header();
                Console.WriteLine("This is your exchange conversion!");
                Console.WriteLine(1.40 * UInput + " USD");
                Header();
                Console.WriteLine("This is your Transaction Fee!");
                transactionFEE();
                Header();
                Console.WriteLine("Exchange rates + Transaction fee");
                TransactionAndConversionDollars();
            }
            else if (userCurrency == 2)
            {
                Console.WriteLine("You have chosen Euros");
                Header();
                Console.WriteLine("Exchange Rates");
                Header();
                Console.WriteLine("This is your exchange conversion!");
                Console.WriteLine(1.14 * UInput + " EUR");
                Header();
                Console.WriteLine("This is your Transaction Fee!");
                transactionFEE();
                Header();
                Console.WriteLine("Exchange rates + Transaction fee");
                TransactionAndConversionEuros();
            }
            else if (userCurrency == 3)
            {
                Console.WriteLine("You have chosen Brazilian Real");
                Header();
                Console.WriteLine("Exchange Rates");
                Header();
                Console.WriteLine("This is your exchange conversion!");
                Console.WriteLine(4.77 * UInput + " BRL");
                Header();
                Console.WriteLine("This is your Transaction Fee!");
                transactionFEE();
                Header();
                Console.WriteLine("Exchange rates + Transaction fee");
                TransactionAndConversionBrazil();

            }
            else if (userCurrency == 4)
            {
                Console.WriteLine("You have chosen Japanese Yen");
                Header();
                Console.WriteLine("Exchange Rates");
                Header();
                Console.WriteLine("This is your exchange conversion!");
                Console.WriteLine(151.05 * UInput + " JPY");
                Header();
                Console.WriteLine("This is your Transaction Fee!");
                transactionFEE();
                Header();
                Console.WriteLine("Exchange rates + Transaction fee");
                TransactionAndConversionJapan();

            }
            else if (userCurrency == 5)
            {
                Console.WriteLine("You have chosen Turkish Lira");
                Header();
                Console.WriteLine("Exchange Rates");
                Header();
                Console.WriteLine("This is your exchange conversion!");
                Console.WriteLine(5.68 * UInput+ " TRY");
                Header();
                Console.WriteLine("This is your Transaction Fee!");
                transactionFEE();
                Header();
                Console.WriteLine("Exchange rates + Transaction fee");
                TransactionAndConversionTurkish();
            }



            Console.ReadLine();
        }
        private static void Header()
        {
            Console.WriteLine("-------------------------");
        }
        private static void transactionFEE()
        {
            if (UInput > 300)
            {
                Answer = UInput * 0.03;
                Console.WriteLine(UInput + Answer);
            }
            else if (UInput > 750)
            {
                Answer = UInput * 0.025;
                Console.WriteLine(UInput + Answer);
            }
            else if (UInput > 1000)
            {
                Answer = UInput * 0.02;
                Console.WriteLine(UInput + Answer);
            }
            else if (UInput > 2000)
            {
                Answer = UInput * 0.015;
                Console.WriteLine(UInput + Answer);
            }
        }
        private static void TransactionAndConversionDollars()
        {
            Console.WriteLine(Answer + (UInput * 1.40));
        }
        private static void TransactionAndConversionEuros()
        {
            Console.WriteLine(Answer + (UInput * 1.14));
        }
        private static void TransactionAndConversionBrazil()
        {
            Console.WriteLine(Answer + (UInput * 4.77));
        }
        private static void TransactionAndConversionJapan()
        {
            Console.WriteLine(Answer + (UInput * 151.05));
        }
        private static void TransactionAndConversionTurkish()
        {
            Console.WriteLine(Answer + (UInput * 5.68));
        }
    }
}
