using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karl_axels_cmd_adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean harNyckel = false;
            string input;

            Console.WriteLine( "---Välkommen till Karl-Axels Command Line Adventure---");
            Console.WriteLine("\nDu står i ett tomt rum. Detta enda som finns är en dörr framför dig. Det ligger en nyckel på golvet");

            while (true) //oändlig loop
            {
                Console.Write("\n>");
                input = Console.ReadLine();

                if (input == "dörr" || input == "öppna dörr"  || input == "gå till dörr")
                {
                    if (harNyckel)
                    {
                        Console.WriteLine("Du öppnar dörren och går igenom");
                        break;
                    }
                    else
                        Console.WriteLine("Den är låst");
                }

                else if (input == "nyckel" || input == "ta nyckel")
                {
                    Console.WriteLine("Du tog nyckeln");
                    harNyckel = true;
                }
                else
                    Console.WriteLine("Icke gilltigt eller felstavat commando!");

            }

            Console.WriteLine("\nDu vann!!! Spelet stängs av...");
            Console.ReadLine();
        }
    }
}
