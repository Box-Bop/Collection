using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections

            //var cars = new List<string>();

            //var car1 = "BMW";
            //var car2 = "Lada";
            //var car3 = "Mercedes";
            //var car4 = "Ferrari";
            //var car5 = "Opel";
            //var car6 = "Saab";

            //cars.Add(car1);
            //cars.Add(car2);
            //cars.Add(car3);
            //cars.Add(car4);
            //cars.Add(car5);
            //cars.Add(car6);

            //foreach (var car in cars)
            //{
            //    Console.WriteLine(car);
            //}











            var cars = new List<string> { "BMW", "Lada", "Mercedes", "Ferrari", "Opel", "Saab" };
            var elementcount = cars.Count;
            for (int index = 0; index < cars.Count; index++)
            {
                Console.WriteLine(cars[index]);
            }

            var humans2 = new List<Human> { };
            Console.WriteLine("***");
            bool dec = true;
            while (dec == true)
            {
                var human3 = new Human();
                Console.WriteLine("Enter your name: ");
                human3.Name = Console.ReadLine();
                Console.WriteLine("Enter your age: ");
                human3.Age = int.Parse(Console.ReadLine());
                humans2.Add(human3);
                Console.Clear();
                bool repeat = true;
                while (repeat == true)
                {
                    Console.WriteLine("Great! Do you wish to add another user? Y/N");
                    string dec2 = Console.ReadLine();
                    switch (dec2)
                    {
                        case "Y":
                            repeat = false;
                            break;
                        case "N":
                            repeat = false;
                            dec = false;
                            break;
                        default:
                            Console.WriteLine("Invalid option\n");
                            break;
                    }
                }
            }
            foreach (var item in humans2)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }

            Console.WriteLine("***");










            //Dictionary

            var openWith = new Dictionary<string, string>();
            //            key      value
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("jpg", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            openWith["rtf"] = "winword.exe";
            openWith["doc"] = "winword.exe";

            try
            {
                openWith.Add("txt", "wordpad.exe");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An element with the key \"txt\" already exists.");
            }


            Console.WriteLine("For key = rtf, value = {0}", openWith["rtf"]);
            Console.WriteLine("For key = doc, value = {0}", openWith["doc"]);

            try
            {
                Console.WriteLine("For key = tif, value = {0}", openWith["tif"]);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("An element with the key \"tif\" does not exist lol.");
                throw;
            }

            string value = "";
            if (openWith.TryGetValue("rtf", out value))
            {
                Console.WriteLine("Foe key = \"tif\", value = {0}", value);
            }
            else
            {
                Console.WriteLine("Key \"tif\" is not found");
            }

            if (!openWith.ContainsKey("ht "))
            {
                openWith.Add("ht ", "hyperterm.exe");
                Console.WriteLine("Value added for key ht : {0}", openWith["ht "]);
            }

            Console.WriteLine("***");















            var humans1 = new List<Human>
            {
                new Human(){Name = "Kalle", Age = 20 },
                new Human(){Name = "Malle", Age = 25 },
                new Human(){Name = "Mari", Age = 30 },
                new Human(){Name = "Elmar", Age = 20 },
                new Human(){Name = "Juku", Age = 20 },

            };

            var human1 = new Human();
            human1.Name = "Priit";
            human1.Age = 25;
            humans1.Add(human1);

            var human2 = new Human();
            Console.WriteLine("Enter your name: ");
            human2.Name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            human2.Age = int.Parse(Console.ReadLine());
            humans1.Add(human2);

            foreach (var item in humans1)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }

            Console.ReadLine();
        }
    }
}
