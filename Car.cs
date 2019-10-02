using System;
using System.Collections.Generic;
using System.Linq;

namespace Multifabriken
{
    class Car
    {

        private List<String> models = new List<string>();

        private string model;
        private string color;
        private bool lyx;

        public string Model{
            get{
                return model;
            }
            set{
                model = value;
            }
        }

        public string Color{
            get{
                return color;
            }
            set{
                color = value;
            }
        }

        public bool Lyx{
            get{
                return lyx;
            }
            set{
                lyx = value;
            }
        }
        
        public Car(){
            models.Add("Volvo");
            models.Add("BMW");
            models.Add("Audi");

            ChooseModel();
            ChooseColor();
            UpgradePack();
            RecieptCar();
        }

        public void ChooseModel(){

            Console.WriteLine("Här har du alla modeller du kan välja mellan!\n\n");

            for (int i = 0; i < models.Count; i++)
            {
                int number = i + 1;
                Console.WriteLine("[" + number + "] " + models[i]);
            }

            Console.WriteLine("\n\nVälj vilken du vill ha");

            int menuChoice = Convert.ToInt32(Console.ReadLine());

            switch (menuChoice)
            {
                case 1 :
                    Model = "Volvo";
                break;
                case 2 :
                    Model = "BMW";
                break;
                case 3 :
                    Model = "Audi";
                break;
                default:
                break;
            }
        }

        public void ChooseColor(){

            Console.Clear();
            Console.WriteLine("Här kan du välja vilken färg du vill ha!\n\n");
            Console.Write("Skriv din färg: ");
            string answer = Console.ReadLine();

            Color = answer;

        }

        public void UpgradePack(){
            Console.Clear();
            Console.WriteLine("Nu kan du välja om du vill ha lyxmodellen!\n\n");
            Console.WriteLine("[1] Ja [2] Nej");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1)
            {
                Lyx = true;
            }
            else if (answer == 2)
            {
                Lyx = false;
            }

        }

        public void RecieptCar(){
            Console.WriteLine("Du har nu beställt en bil med");
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Färg: " + Color);
            Console.WriteLine("Lyx: " + Lyx);
        }
    }
}