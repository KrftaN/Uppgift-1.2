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

            Console.WriteLine(
                "An error has occurred. To continue:\n\nPress enter to return to Windows, or \n\nPress CTRL+ALT+DEL to restart your computer. If you do this, \nyou will lose any unsaved information in all open applications.\n\nError: 0e : 016F : BFF9B3D4\nPress any key to continue"
            );
            Console.ReadKey();
        }
    }
}
