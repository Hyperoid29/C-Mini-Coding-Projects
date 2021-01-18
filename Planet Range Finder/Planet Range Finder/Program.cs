using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planet_Range_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] arrconversion = new float[8];

            float Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune;
            int UInput; 

            Header();
            Console.WriteLine("Choose a planet!");
            Header();
            Console.WriteLine("(0) Mercury");
            Console.WriteLine("(1) Venus");
            Console.WriteLine("(2) Earth");
            Console.WriteLine("(3) Mars");
            Console.WriteLine("(4) Jupiter");
            Console.WriteLine("(5) Saturn");
            Console.WriteLine("(6) Uranus");
            Console.WriteLine("(7) Neptune");

            string[] PlanetName = new string[8];
            PlanetName[0] = "(0) Mercury";
            PlanetName[1] = "(1) Venus";
            PlanetName[2] = "(2) Earth";
            PlanetName[3] = "(3) Mars";
            PlanetName[4] = "(4) Jupiter";
            PlanetName[5] = "(5) Saturn";
            PlanetName[6] = "(6) Uranus";
            PlanetName[7] = "(7) Neptune";
            UInput = Int32.Parse(Console.ReadLine());


            if (UInput == 0)
            {
                Console.WriteLine("You have chosen Mercury ");
                Header();
                Console.WriteLine("Distance between Mercury and Venus = 31,248,757 miles");
                Header();
                Console.WriteLine("Distance between Mercury and Earth = 56,974,146 miles");
                Header();
                Console.WriteLine("Distance between Mercury and Mars = 105,651,744 miles");
                Header();
                Console.WriteLine("Distance between Mercury and Jupiter = 447,648,234 miles");
                Header();
                Console.WriteLine("Distance between Mercury and Saturn = 849,221,795 miles");
                Header();
                Console.WriteLine("Distance between Mercury and Uranus = 1,749,638,696 miles");
                Header();
                Console.WriteLine("Distance between Mercury and Neptune = 2,760,936,126 miles");
                Header();
                Quit();

            }
            else if (UInput == 1)
            {
                Console.WriteLine("You have chosen Venus ");
                Header();
                Console.WriteLine("Distance between Venus and Mercury = 31,248,757 miles");
                Header();
                Console.WriteLine("Distance between Venus and Earth = 25,724,767 miles");
                Header();
                Console.WriteLine("Distance between Venus and Mars = 74,402,987 miles");
                Header();
                Console.WriteLine("Distance between Venus and Jupiter = 416,399,477 miles");
                Header();
                Console.WriteLine("Distance between Venus and Saturn = 817,973,037 miles");
                Header();
                Console.WriteLine("Distance between Venus and Uranus = 1,718,388,490 miles");
                Header();
                Console.WriteLine("Distance between Venus and Neptune = 2,729,685,920 miles");
                Header();
                Quit();
            }
            else if (UInput == 2)
            {
                Console.WriteLine("You have chosen Earth ");
                Header();
                Console.WriteLine("Distance between Earth and Mercury = 56,974,146 miles");
                Header();
                Console.WriteLine("Distance between Earth and Venus = 25,724,767 miles");
                Header();
                Console.WriteLine("Distance between Earth and Mars = 48,678,219 miles");
                Header();
                Console.WriteLine("Distance between Earth and Jupiter = 390,674,710 miles");
                Header();
                Console.WriteLine("Distance between Earth and Saturn = 792,248,270 miles");
                Header();
                Console.WriteLine("Distance between Earth and Uranus = 1,692,662,530 miles");
                Header();
                Console.WriteLine("Distance between Earth and Neptune = 2,703,959,960 miles");
                Header();
                Quit();
            }
            else if (UInput == 3)
            {
                Console.WriteLine("You have chosen Mars ");
                Header();
                Console.WriteLine("Distance between Mars and Mercury = 105,651,744 miles");
                Header();
                Console.WriteLine("Distance between Mars and Venus = 74,402,987 miles");
                Header();
                Console.WriteLine("Distance between Mars and Earth = 48,678,219 miles");
                Header();
                Console.WriteLine("Distance between Mars and Jupiter = 342,012,346 miles");
                Header();
                Console.WriteLine("Distance between Mars and Saturn = 743,604,524 miles");
                Header();
                Console.WriteLine("Distance between Mars and Uranus = 1,643,982,054 miles");
                Header();
                Console.WriteLine("Distance between Mars and Neptune = 2,655,279,484 miles");
                Header();
                Quit();
            }
            else if (UInput == 4)
            {
                Console.WriteLine("You have chosen Jupiter ");
                Header();
                Console.WriteLine("Distance between Jupiter and Mercury = 447,648,234 miles");
                Header();
                Console.WriteLine("Distance between Jupiter and Venus =  416,399,477 miles");
                Header();
                Console.WriteLine("Distance between Jupiter and Earth = 390,674,710 miles");
                Header();
                Console.WriteLine("Distance between Jupiter and Mars =  342,012,346 miles");
                Header();
                Console.WriteLine("Distance between Jupiter and Saturn = 401,592,178 miles");
                Header();
                Console.WriteLine("Distance between Jupiter and Uranus = 1,301,969,708 miles");
                Header();
                Console.WriteLine("Distance between Jupiter and Neptune = 2,313,267,138 miles");
                Header();
                Quit();
            }
            else if (UInput == 5)
            {
                Console.WriteLine("You have chosen Saturn ");
                Header();
                Console.WriteLine("Distance between Saturn and Mercury = 849,221,795 miles");
                Header();
                Console.WriteLine("Distance between Saturn and Venus =  817,973,037 miles");
                Header();
                Console.WriteLine("Distance between Saturn and Earth = 792,248,270 miles");
                Header();
                Console.WriteLine("Distance between Saturn and Mars =  743,604,524 miles");
                Header();
                Console.WriteLine("Distance between Saturn and Jupiter = 401,592,178 miles");
                Header();
                Console.WriteLine("Distance between Saturn and Uranus =  900,377,530 miles");
                Header();
                Console.WriteLine("Distance between Saturn and Neptune = 1,911,674,960 miles");
                Header();
                Quit();
            }
            else if (UInput == 6)
            {
                Console.WriteLine("You have chosen Uranus");
                Header();
                Console.WriteLine("Distance between Uranus and Mercury = 1,749,638,696 miles");
                Header();
                Console.WriteLine("Distance between Uranus and Venus =  1,718,388,490 miles");
                Header();
                Console.WriteLine("Distance between Uranus and Earth = 1,692,662,530 miles");
                Header();
                Console.WriteLine("Distance between Uranus and Mars =  1,643,982,054 miles");
                Header();
                Console.WriteLine("Distance between Uranus and Jupiter = 1,301,969,708 miles");
                Header();
                Console.WriteLine("Distance between Uranus and Saturn =  900,377,530 miles");
                Header();
                Console.WriteLine("Distance between Uranus and Neptune = 1,011,297,430 miles");
                Header();
                Quit();
            }
            else if (UInput == 7)
            {
                Console.WriteLine("You have chosen Neptune");
                Header();
                Console.WriteLine("Distance between Neptune and Mercury = 1,749,638,696 miles");
                Header();
                Console.WriteLine("Distance between Neptune and Venus =  1,718,388,490 miles");
                Header();
                Console.WriteLine("Distance between Neptune and Earth = 1,692,662,530 miles");
                Header();
                Console.WriteLine("Distance between Neptune and Mars =  1,643,982,054 miles");
                Header();
                Console.WriteLine("Distance between Neptune and Jupiter = 1,301,969,708 miles");
                Header();
                Console.WriteLine("Distance between Neptune and Saturn =  900,377,530 miles");
                Header();
                Console.WriteLine("Distance between Neptune and Neptune = 1,011,297,430 miles");
                Header();
                Quit();
            }








            Console.ReadLine();
        }
        private static void Header()
        {
            Console.WriteLine("-------------------------------");
        }
        private static void Quit()
        {
            Console.WriteLine("Press /'q'/ in order to quit the program.");
        }
    }
}
