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
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hello Welcome to my animal generator!");
                Console.ResetColor();
                Console.WriteLine();

                Console.WriteLine("What is your favorite animal?");
                string Animal = Console.ReadLine();

                Console.WriteLine();

                Console.WriteLine("Pick a random number");
                string Legs = Console.ReadLine();
                Convert.ToInt32(Legs);

                Console.WriteLine();

                bool Error = true;
                while (Error)
                {
                    Console.Write("Pick a Color: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Yellow");
                    Console.ResetColor();
                    Console.Write(" or ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Blue");
                    Console.ResetColor();

                    string Color = Console.ReadLine().ToLower();


                    Console.WriteLine();
                    Console.WriteLine("To Generate your animal press Enter");
                    Console.ReadLine();

                    if (Color == "yellow")
                    {
                        Console.WriteLine();
                        Console.Write("Your animal is a " + Animal + "\nit is ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("yellow");
                        Console.ResetColor();
                        Console.WriteLine(" with 1 eye \nand it has " + Legs + " legs \n");
                    }

                    else if (Color == "blue")
                    {
                        Console.WriteLine();
                        Console.Write("Your animal is a " + Animal + "\nit is ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("blue");
                        Console.ResetColor();
                        Console.WriteLine(" with 5 eyes \nand it has " + Legs + " legs \n");
                    }

                    else if (Color != "yellow" && Color != "blue")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please try again");
                        Console.WriteLine();
                        Error = true;
                    }
                    else //if (Color == "yellow" || Color == "blue")
                    {
                        //Console.WriteLine();
                        //Error = false;
                        continue;
                    }
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Would you like to generate another animal?");
                Console.ResetColor();
                string Response = Console.ReadLine().ToLower();

                if (Response == "yes")
                {
                    Console.WriteLine();
                    Answer = true;
                }

                else
                {
                    Console.WriteLine();
                    Answer = false;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Thank you for using my animal generator!");
                    Console.ResetColor();

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                }

            }
        }
    }
}
