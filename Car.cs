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
                model = Model;
            }
        }

        public string Color{
            get{
                return color;
            }
            set{
                model = Color;
            }
        }

        public bool Lyx{
            get{
                return lyx;
            }
            set{
                lyx = Lyx;
            }
        }
        
        public Car(string carModel, string carColor, bool carLyx){

            Model = carModel;
            Color = carColor;
            Lyx = carLyx;

            models.Add("Volvo");
            models.Add("BMW");
            models.Add("Audi");

        }

        public void ChooseModel(){

            Console.WriteLine("Här har du alla modeller du kan välja mellan! \n\n");

            foreach (string model in models)
            {
                Console.WriteLine(model.Count() + " " + model);
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
    }
}