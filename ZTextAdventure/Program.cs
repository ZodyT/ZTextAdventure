using System;

namespace ZTextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello Welcome to my animal generator");

            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();

            Console.WriteLine("Pick a Color: Red or Blue?");
            string Color = Console.ReadLine();
            Color = Color.ToLower();

            Console.WriteLine("Pick a random number.");
            string Legs = Console.ReadLine();
            Convert.ToInt32(Legs);



        }
    }
}
