using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu
{
    internal class Game
    {
        private readonly string _title = @"
  █████▒▄▄▄       ███▄    █  ▄████▄▓██   ██▓     ▄████  ▄▄▄       ███▄ ▄███▓▓█████ 
▓██   ▒▒████▄     ██ ▀█   █ ▒██▀ ▀█ ▒██  ██▒    ██▒ ▀█▒▒████▄    ▓██▒▀█▀ ██▒▓█   ▀ 
▒████ ░▒██  ▀█▄  ▓██  ▀█ ██▒▒▓█    ▄ ▒██ ██░   ▒██░▄▄▄░▒██  ▀█▄  ▓██    ▓██░▒███   
░▓█▒  ░░██▄▄▄▄██ ▓██▒  ▐▌██▒▒▓▓▄ ▄██▒░ ▐██▓░   ░▓█  ██▓░██▄▄▄▄██ ▒██    ▒██ ▒▓█  ▄ 
░▒█░    ▓█   ▓██▒▒██░   ▓██░▒ ▓███▀ ░░ ██▒▓░   ░▒▓███▀▒ ▓█   ▓██▒▒██▒   ░██▒░▒████▒
 ▒ ░    ▒▒   ▓▒█░░ ▒░   ▒ ▒ ░ ░▒ ▒  ░ ██▒▒▒     ░▒   ▒  ▒▒   ▓▒█░░ ▒░   ░  ░░░ ▒░ ░
 ░       ▒   ▒▒ ░░ ░░   ░ ▒░  ░  ▒  ▓██ ░▒░      ░   ░   ▒   ▒▒ ░░  ░      ░ ░ ░  ░
 ░ ░     ░   ▒      ░   ░ ░ ░       ▒ ▒ ░░     ░ ░   ░   ░   ▒   ░      ░      ░   
             ░  ░         ░ ░ ░     ░ ░              ░       ░  ░       ░      ░  ░
                            ░       ░ ░                                            
";
        public void Start()
        {
            Console.Title = "Game title";
            Console.CursorVisible = false;
            CreateMenu();
        }
        private void CreateMenu()
        {
            string[] options = new string[] { "Play", "About", "Exit" };
            Menu mainMenu = new Menu(_title, options);
            int index = mainMenu.Run();
            switch (index)
            {
                case 0:
                    Run(); break;
                case 1:
                    Info(); break;
                case 2:
                    Exit(); break;
            }
        }
        private void Run()
        {
            Console.Clear();
            Console.WriteLine("Demo console-game");
            Exit();
        }
        private void Info()
        {
            Console.Clear();
            Console.WriteLine("Demo console-game");
            Console.WriteLine("Press any key to return the menu");
            Console.ReadKey();
            CreateMenu();
        }
        private void Exit()
        {
            Environment.Exit(0);
        }

    }
}
