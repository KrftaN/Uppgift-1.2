using System;

namespace Uppgift_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ändra bakgrundsfärg till mörkblå
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            // Ändra textfärgen till vit
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Någonting gick fel. Pröva starta om datorn.");
        }
    }
}
