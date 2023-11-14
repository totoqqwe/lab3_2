using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure triangle = new Figure(new Point(0, 0, "A"), new Point(0, 1, "B"), new Point(1, 0, "C"));

            triangle.CalculatePerimeter();
        }
    }
}
