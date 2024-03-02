using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu
{
    internal class Menu
    {
        private int _selectedIndex;
        private readonly string _title;
        private readonly string[] _options;

        public Menu(string title, string[] options)
        {
            _title = title;
            _options = options;
            _selectedIndex = 0;
        }
        private void DispplayOptions()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(_title);
            string prefix = string.Empty;
            for (int i = 0; i < _options.Length; i++)
            {
                string currentOptions = _options[i];
                if (i == _selectedIndex)
                {
                    prefix = "*";
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = " ";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine("{0} << {1} >>", prefix, currentOptions);
            }
            Console.ResetColor();
        }
        public int Run()
        {
            ConsoleKey keyPressed;
            do
            {
                Console.Clear();
                DispplayOptions();

                keyPressed = Console.ReadKey().Key;

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    _selectedIndex--;
                    if (_selectedIndex == -1)
                        _selectedIndex = 0;
                }
                if (keyPressed == ConsoleKey.DownArrow)
                { 
                    _selectedIndex++;
                    if (_selectedIndex == _options.Length)
                        _selectedIndex = _options.Length - 1;
                }
            }
            while (keyPressed != ConsoleKey.Enter);
            return _selectedIndex;
        }
    }
}
