using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();

            box.B = 2;
            box.L = 5;
            box.H = 3;

            box.Show();

            float f = box.Volume();
            Console.WriteLine($"Объем коробки = {f}");

            Console.ReadLine();
        }
    }
}
