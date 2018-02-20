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
            #region Lists<>
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











            //var cars = new List<string> { "BMW", "Lada", "Mercedes", "Ferrari", "Opel", "Saab" };
            //var elementcount = cars.Count;
            //for (int index = 0; index < cars.Count; index++)
            //{
            //    Console.WriteLine(cars[index]);
            //}

            //var humans2 = new List<Human> { };
            //Console.WriteLine("***");
            //bool dec = true;
            //while (dec == true)
            //{
            //    var human3 = new Human();
            //    Console.WriteLine("Enter your name: ");
            //    human3.Name = Console.ReadLine();
            //    Console.WriteLine("Enter your age: ");
            //    human3.Age = int.Parse(Console.ReadLine());
            //    humans2.Add(human3);
            //    Console.Clear();
            //    bool repeat = true;
            //    while (repeat == true)
            //    {
            //        Console.WriteLine("Great! Do you wish to add another user? Y/N");
            //        string dec2 = Console.ReadLine();
            //        switch (dec2)
            //        {
            //            case "Y":
            //                repeat = false;
            //                break;
            //            case "N":
            //                repeat = false;
            //                dec = false;
            //                break;
            //            default:
            //                Console.WriteLine("Invalid option\n");
            //                break;
            //        }
            //    }
            //}
            //foreach (var item in humans2)
            //{
            //    Console.WriteLine(item.Name + " " + item.Age);
            //}

            //Console.WriteLine("***");

            //var humans1 = new List<Human>
            //{
            //    new Human(){Name = "Kalle", Age = 20 },
            //    new Human(){Name = "Malle", Age = 25 },
            //    new Human(){Name = "Mari", Age = 30 },
            //    new Human(){Name = "Elmar", Age = 20 },
            //    new Human(){Name = "Juku", Age = 20 },

            //};

            //var human1 = new Human();
            //human1.Name = "Priit";
            //human1.Age = 25;
            //humans1.Add(human1);

            //var human2 = new Human();
            //Console.WriteLine("Enter your name: ");
            //human2.Name = Console.ReadLine();
            //Console.WriteLine("Enter your age: ");
            //human2.Age = int.Parse(Console.ReadLine());
            //humans1.Add(human2);

            //foreach (var item in humans1)
            //{
            //    Console.WriteLine(item.Name + " " + item.Age);
            //}

            #endregion Lists<>

            #region Dictionary

            //var openWith = new Dictionary<string, string>();
            ////            key      value
            //openWith.Add("txt", "notepad.exe");
            //openWith.Add("bmp", "paint.exe");
            //openWith.Add("jpg", "paint.exe");
            //openWith.Add("rtf", "wordpad.exe");

            //openWith["rtf"] = "winword.exe";
            //openWith["doc"] = "winword.exe";

            //try
            //{
            //    openWith.Add("txt", "wordpad.exe");
            //}
            //catch (ArgumentException)
            //{
            //    Console.WriteLine("An element with the key \"txt\" already exists.");
            //}


            //Console.WriteLine("For key = rtf, value = {0}", openWith["rtf"]);
            //Console.WriteLine("For key = doc, value = {0}", openWith["doc"]);

            ////try
            ////{
            ////    Console.WriteLine("For key = tif, value = {0}", openWith["tif"]);
            ////}
            ////catch (KeyNotFoundException)
            ////{
            ////    Console.WriteLine("An element with the key \"tif\" does not exist lol.");
            ////    throw;
            ////}

            //string value = "";
            //if (openWith.TryGetValue("rtf", out value))
            //{
            //    Console.WriteLine("Foe key = \"tif\", value = {0}", value);
            //}
            //else
            //{
            //    Console.WriteLine("Key \"tif\" is not found");
            //}

            //if (!openWith.ContainsKey("ht "))
            //{
            //    openWith.Add("ht ", "hyperterm.exe");
            //    Console.WriteLine("Value added for key ht : {0}", openWith["ht "]);
            //}

            ////Asking for keys & values with foreach cycle

            //foreach (KeyValuePair<string, string> kvp in openWith)
            //{
            //    Console.WriteLine("Key = {0} , Value = {1}", kvp.Key, kvp.Value);
            //}

            ////Asking for values
            //Dictionary<string, string>.ValueCollection valueCollection = openWith.Values;
            //foreach (var item in valueCollection)
            //{
            //    Console.WriteLine("Value = {0}", item);
            //}

            ////Asking for keys
            //Dictionary<string, string>.KeyCollection keysCollection = openWith.Keys;
            //foreach (var item in keysCollection)
            //{
            //    Console.WriteLine("Key = {0}", item);
            //}


            ////Deleting key/value
            //openWith.Remove("doc");
            //if (!openWith.ContainsKey("doc"))
            //{
            //    Console.WriteLine("Key \"doc\" is not found.");
            //}

            //Console.WriteLine("***");

            #endregion Dictionary

            #region Queue

            ////Creating Queue

            //Queue<string> numbers = new Queue<string>();
            //numbers.Enqueue("one");
            //numbers.Enqueue("two");
            //numbers.Enqueue("three");
            //numbers.Enqueue("four");
            //numbers.Enqueue("five");


            ////Receiving values out in the correct order

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            ////Getting first out
            //Console.WriteLine();
            //Console.WriteLine("Dequeing '{0}'", numbers.Dequeue());
            ////Checking what's left
            //Console.WriteLine("Next number in the line: {0}", numbers.Peek());
            ////Getting the next number out
            //Console.WriteLine("Dequeing '{0}'", numbers.Dequeue());

            ////Copying the queue
            //Queue<string> queueCopy = new Queue<string>(numbers.ToArray());
            //Console.WriteLine("\nContents of the copied queue");
            //foreach (string num in queueCopy)
            //{
            //    Console.WriteLine(num);
            //}

            ////Something

            //string[] array2 = new string[numbers.Count * 2];
            //numbers.CopyTo(array2, numbers.Count);

            //Queue<string> queueCopy2 = new Queue<string>(array2);
            //Console.WriteLine("\nContents of the second copy, with duplicates & nulls: ");
            //foreach (var number in queueCopy2)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine("\nqueueCopy contains 'four' = {0}", queueCopy.Contains("four"));

            ////Empting queue
            //queueCopy.Clear();
            //Console.WriteLine("\nqueueCopy count is: {0}",queueCopy.Count);


            #endregion Queue

            #region Stack - last in first out

            //Console.WriteLine("");
            //Stack<string> numbers = new Stack<string>();
            //numbers.Push("one");
            //numbers.Push("two");
            //numbers.Push("three");
            //numbers.Push("four");
            //numbers.Push("five");

            //foreach (string number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine("\nPopping '{0}'",numbers.Pop());
            //Console.WriteLine("Peeking at next in line: {0}", numbers.Peek());
            //Console.WriteLine("Popping '{0}'",numbers.Pop());


            #endregion Stack - last in first out

            #region LINQ

            //Data
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            ////Loome päringu
            //var evenNumQuery = (from num in numbers
            //               where (num % 2) == 0
            //               select num).ToList();

            //foreach (int num in numQuery)
            //{
            //    Console.WriteLine("{0,1 }", num);
            //}

            //int evenNumCount = evenNumQuery.Count();


            var humans1 = new List<Human>
            {
                new Human(){Name = "Kalle", Age = 40 },
                new Human(){Name = "Malle", Age = 25 },
                new Human(){Name = "Mari", Age = 30 },
                new Human(){Name = "Elmar", Age = 10 },
                new Human(){Name = "Juku", Age = 80 },
            };

            ////Küsime inimesi kelle vanus on üle 20
            //var query = (from element in humans1
            //             orderby element.Age ascending
            //            where element.Age > 20
            //            select element).ToList();

            //foreach (var item in query)
            //{
            //    Console.WriteLine(item.Name + " " + item.Age);
            //}

            var a = numbers.Contains(7);

            bool b = false;
            foreach (var item in numbers)
            {
                if (item == 6)
                    b = true;
            }

            Console.WriteLine(a);
            Console.WriteLine(b);

                        #endregion LINQ



            Console.ReadLine();

        }
    }
}
