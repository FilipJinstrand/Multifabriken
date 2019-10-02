using System;

namespace Multifabriken
{
    class Program
    {
        static void Main(string[] args)
        {
            bool fabric = true;

            while (fabric)
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

                switch (menuChoice)
                {
                    case 1:
                        MakeOrder();
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
        static public void MakeOrder()
        {
            Console.Clear();
            Console.WriteLine("Vad vill du beställa?");
            Console.WriteLine("[1] Bil");
            Console.WriteLine("[2] Godis");
            Console.WriteLine("[3] Havremjölk");
            Console.WriteLine("[4] Rör");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("\n - Bilbeställning -");
                    Console.WriteLine(" ");
                    Car car = new Car();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("\n - Godisbeställning -");
                    Console.WriteLine(" ");
                    Candy candies = new Candy();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("\n - Havremjölksbeställning -");
                    Console.WriteLine(" ");
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("\n - Rörbeställning -");
                    Console.WriteLine(" ");
                    Pipe pipe = new Pipe();
                    break;

                default:
                    Console.WriteLine("Felaktig inmatning");
                    break;

            }
        }
    }
}
