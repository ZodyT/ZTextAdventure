using System;

namespace ZTextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Answer = true;

            while (Answer)
            {
                Console.WriteLine("Hello Welcome to my animal generator!");

                Console.WriteLine("What is your favorite animal?");
                string Animal = Console.ReadLine();

                Console.WriteLine("Pick a Color: Red or Blue?");
                string Color = Console.ReadLine();
                Color = Color.ToLower();

                    Console.WriteLine("Pick a random number.");
                    string Legs = Console.ReadLine();
                    Convert.ToInt32(Legs);

                    Console.WriteLine("To Generate your animal press Enter");
                    Console.ReadLine();

                    if (Color == "red")
                    {
                        Console.WriteLine("Your animal is a " + Animal + "\nit is red with 1 eye \nand it has " + Legs + " legs \n");
                    }
                    else
                    {
                        Console.WriteLine("Your animal is a " + Animal + "\nit is blue with 5 eyes \nand it has " + Legs + " legs \n");
                    }

                    Console.WriteLine("Would you like to generate another animal?");
                    string Response = Console.ReadLine();
                    Response = Response.ToLower();

                    if (Response == "yes")
                    {
                        Console.WriteLine();
                        Answer = true;
                    }

                    else
                    {
                        Console.WriteLine();
                        Answer = false;
                        Console.WriteLine("Thank you for using my animal generator!");
                    }
                
            }
        }
    }
}
