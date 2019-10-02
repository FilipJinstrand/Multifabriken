using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class Milk
    {
        private List<string> oatMilk = new List<string>();

        private double size;

        private int content;

        public double Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        public int Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
            }
        }

        public Milk()
        {
            oatMilk.Add("0,5 liter");
            oatMilk.Add("1 liter");
            oatMilk.Add("2 liter");

            ChooseSize();
            ChooseContent();
            ReceiptMilk();

        }

        public void ChooseSize()
        {
            Console.Clear();
            Console.WriteLine("Dessa storlekar kan du välja emellan: ");

            for (int i = 0; i < oatMilk.Count; i++)
            {
                int number = i + 1; 
                Console.WriteLine("[" + number + "] " + oatMilk[i]);
            }

            Console.WriteLine("Välj vilken storlek du vill beställa: ");

            int menuChoice = Convert.ToInt32(Console.ReadLine());

            switch (menuChoice)
            {
                case 1: 
                Size = 0.5;
                break;

                case 2:
                Size = 1;
                break;

                case 3:
                Size = 2;
                break;

                default:
                Console.WriteLine("Felaktig inmatning");
                break;
            }

        }

        public void ChooseContent()
        {
            Console.Clear();

            bool fatContent = true;

            while(fatContent)
            {
                Console.WriteLine("Nu får du välja havremjölkens fetthalt mellan 2-11% : ");
                int answer = Convert.ToInt32(Console.ReadLine());

                if (answer > 2 && answer < 11)
                {
                    content = answer;
                    fatContent = false;
                }
                else
                {
                    Console.WriteLine("Du kan bara välja en fetthalt mellan 2-11%");
                }
            }
        }

        public void ReceiptMilk()
        {
            Console.WriteLine("Du har beställt: ");
            Console.WriteLine(Size + "mjölk med " + Content + "% fetthalt.");
        }
    }
}