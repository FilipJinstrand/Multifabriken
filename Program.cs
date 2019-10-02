using System;

namespace Multifabriken
{
    class Program
    {
        static void Main(string[] args)
        {
            bool fabric = true;

            while(fabric)
            {
                Console.WriteLine(" ");
                Console.WriteLine("\n - Välkommen till huvudmenyn för Multifabriken AB -");
                Console.WriteLine(" ");

                Console.WriteLine("[1] Gör en beställning");
                Console.WriteLine("[2] Se innehållet i min beställning");
                Console.WriteLine("[0] Avsluta programmet");
                Console.WriteLine(" ");
                Console.Write("Välj ett alternativ genom att trycka på den motsvarande siffrans tangent: ");
                Console.WriteLine(" ");

                int menuChoice = Convert.ToInt32(Console.ReadLine());

                switch(menuChoice)
                {
                    case 1:
                    break;

                    case 2:
                    break; 

                    case 0: 
                    Console.Clear();
                    Console.WriteLine("Programmet avslutas...");
                    return;

                    default:
                    Console.WriteLine("Felaktig inmatning");
                    break;

                }
            }
        }
    }
}
