using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Extra__Oefening__Muziek_En_Methoden
{
    internal class MainMenu
    {
        public void MainMenuDisplay() 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
█▀ █▀▀ █░░ █▀▀ █▀▀ ▀█▀
▄█ ██▄ █▄▄ ██▄ █▄▄ ░█░");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"
▄▀█ ▀▄
█▀█ ▄▀");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(@"
▄▀█ █▀▀ ░░▄▀ █▀▄ █▀▀   ▄▄   █░█ █ █▀▀ █░█ █░█░█ ▄▀█ █▄█   ▀█▀ █▀█   █░█ █▀▀ █░░ █░░
█▀█ █▄▄ ▄▀░░ █▄▀ █▄▄   ░░   █▀█ █ █▄█ █▀█ ▀▄▀▄▀ █▀█ ░█░   ░█░ █▄█   █▀█ ██▄ █▄▄ █▄▄");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.Write(@"
█▄▄ ▀▄
█▄█ ▄▀");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(@"
█▀▄▀█ █▀█ ▀█ ▄▀█ █▀█ ▀█▀   ▄▄   █▀▀ █░█ █▀█   █▀▀ █░░ █ █▀ █▀▀
█░▀░█ █▄█ █▄ █▀█ █▀▄ ░█░   ░░   █▀░ █▄█ █▀▄   ██▄ █▄▄ █ ▄█ ██▄");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.Write(@"
█▀▀ ▀▄
█▄▄ ▄▀");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(@"
█▄▄ ▄▀█ █▀█ ▀█▀   █▀█ █▀█ █▀▀ █░░ █▀   ▄▄   █▀▄▀█ █▀█ █░░ █░░ ▄▀█
█▄█ █▀█ █▀▄ ░█░   █▀▄ █▄█ ██▄ █▄▄ ▄█   ░░   █░▀░█ █▄█ █▄▄ █▄▄ █▀█");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.Write(@"
█▀▄ ▀▄
█▄▀ ▄▀");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(@"
█▀▀ █▀█ █▀▄▀█ █▀█ █░█ ▀█▀ █▀▀ █▀█  █▀█ ▄▀█ █▄░█ █▀▄ █▀█ █▀▄▀█
█▄▄ █▄█ █░▀░█ █▀▀ █▄█ ░█░ ██▄ █▀▄  █▀▄ █▀█ █░▀█ █▄▀ █▄█ █░▀░█");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.Write(@"
▀▄▀   █▀ ▀█▀ █▀█ █▀█
█░█   ▄█ ░█░ █▄█ █▀▀");
            Console.WriteLine("♯");

        }
    }
}
