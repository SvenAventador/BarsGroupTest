using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var firstValue = new MyFirstEvent();
            firstValue.OnKeyPressed += (Sender, ButtonWrite) => Console.WriteLine("\n" + ButtonWrite);
            firstValue.Run();
        }
        public static void WriteChar(object sender, char value)
        {
            Console.WriteLine(value);
        }
    }
}