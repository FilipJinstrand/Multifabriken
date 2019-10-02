using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class Candy
    {
        private List<string> candies = new List<string>();

        private string type;

        private int volume;

        public string Type
        {
            get
            {
                return type;    
            }
            set
            {
                type = value;
            }
        }

        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                volume = value;
            }
        }

        public Candy()
        {
            candies.Add("Sött godis");
            candies.Add("Surt godis");
            candies.Add("Salt godis");

            ChooseSort();
            ChooseVolume();
            ReceiptCandy();
        }

        public void ChooseSort()
        {
            Console.Clear();
            Console.WriteLine("Dessa godissorter kan du välja emellan! \n\n");

            for (int i = 0; i < candies.Count; i++)
            {
                int number = i + 1;
                Console.WriteLine("[" + number + "] " + candies[i]);
            }

            Console.WriteLine("Välj vilken sort du vill beställa:");

            int menuChoice = Convert.ToInt32(Console.ReadLine());

            switch (menuChoice)
            {
                case 1:
                Type = "Sött godis";
                break;

                case 2:

                Type = "Surt godis";
                break;

                case 3:
                Type = "Salt godis";
                break;
                
                default:
                Console.WriteLine("Felaktig inmatning");
                break;
            }

        }

        public void ChooseVolume()
        {
            Console.Clear();
            Console.Write("Skriv in hur många kilo godis du vill beställa: ");
            int input = Convert.ToInt32(Console.ReadLine());

            Volume = input;
        }

        public void ReceiptCandy()
        {
            Console.Clear();
            Console.WriteLine("Du har nu beställt:");
            Console.WriteLine(Volume + "kg av " + Type);
        }
    }
}