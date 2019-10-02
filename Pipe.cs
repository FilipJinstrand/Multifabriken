using System;
using System.Collections.Generic;
using System.Linq;

namespace Multifabriken
{
    class Pipe
    {
        private List<String> types = new List<string>();

        private string type;
        private double length;
        private double diameter;

        public string Type{
            get{
                return type;
            }
            set{
                type = value;
            }
        }

        public double Length{
            get{
                return length;
            }
            set{
                length = value;
            }
        }

        public double Diamater{
            get{
                return diameter;
            }
            set{
                diameter = value;
            }
        }

        public Pipe(){
            types.Add("Rostfritt stål");
            types.Add("Betong");
            types.Add("Metall");

            ChooseType();
            ChooseLength();
            ChooseDiameter();
        }

        private void ChooseType(){
            Console.Clear();

            Console.WriteLine("Här kan du välja vilket matrial röret ska ha");

            for (int i = 0; i < types.Count; i++)
            {
                int number = i + 1;
                Console.WriteLine("[" + number + "] " + types[i]);
            }

            Console.WriteLine("\n\nVälj vilken du vill ha");

            int menuChoice = Convert.ToInt32(Console.ReadLine());

            switch (menuChoice)
            {
                case 1 :
                    Type = "Rostfritt stål";
                break;
                case 2 :
                    Type = "Betong";
                break;
                case 3 :
                    Type = "Metall";
                break;
                default:
                break;
            }

        }

        private void ChooseLength(){
            Console.Clear();

            Console.WriteLine("Nu kan du välja hur lång den ska vara i M");

            Console.Write("Skriv i M: ");

            double answer = Convert.ToDouble(Console.ReadLine());

            Length = answer;
        }

        private void ChooseDiameter(){
            Console.Clear();

            Console.WriteLine("Nu kan du välja hur bred den ska vara i M");

            Console.Write("Skriv i M: ");

            double answer = Convert.ToDouble(Console.ReadLine());

            Diamater = answer;
        }

        private void RecieptPipe(){
            Console.Clear();
            
            Console.WriteLine("Du har nu beställt ett rör med:");
            Console.WriteLine("Typ: " + Type);
            Console.WriteLine("Längd: " + Length + " M");
            Console.WriteLine("Diameter: " + Diamater + "M");
        }

    }
}