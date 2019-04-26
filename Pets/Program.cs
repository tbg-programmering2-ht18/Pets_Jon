using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static List<Animal> animals = new List<Animal>();
        private static readonly Random getrandom = new Random();

        static void Main(string[] args)
        {


            animals.Add(new Cat("BOI"));
            animals.Add(new Dog("Bubb"));
            animals.Add(new Bird("YEET")); //Test
            animals.Add(new Cat("meh")); //Adds things to the list animals

            Console.WriteLine(@"

Välkommen...
            Kidnappa ett djur!
Tryck på en knapp! (esc. dödar allt...)");




            ConsoleKey ck = Console.ReadKey().Key;
            while(ck !=ConsoleKey.Escape)
            {
                int n = getrandom.Next(0, animals.Count - 1);
                Console.WriteLine("\nYour animal is...");
                Console.WriteLine(animals[n].Show());
                Console.WriteLine("Press ESC to quit or any key to continue: \n");
                ck = Console.ReadKey().Key;

            }
        }
    }
}
