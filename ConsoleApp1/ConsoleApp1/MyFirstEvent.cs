using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyFirstEvent
    {
        public event EventHandler<char> ? OnKeyPressed;

        public void Run()
        {
            char chars = Console.ReadKey().KeyChar;
            while((char.ToLower(chars) != 'c') && (char.ToLower(chars) != 'с'))
            {
                OnKeyPressed?.Invoke(this, chars);
                chars = Console.ReadKey().KeyChar;
            }
            Console.WriteLine("\nКонец программы :(");
        }
    }
}


