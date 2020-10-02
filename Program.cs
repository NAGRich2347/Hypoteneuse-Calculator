using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypotenuse_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double legOne;
            Console.WriteLine("Please enter the length of the first triangle leg.");
            legOne = Convert.ToDouble(Console.ReadLine());

            double legTwo;
            Console.WriteLine("Please enter the length of the second triangle leg.");
            legTwo = Convert.ToDouble(Console.ReadLine());

            double hypoLength = Math.Sqrt((legOne * legOne) + (legTwo * legTwo));
            Console.WriteLine($"The length of your hypotenuse is {hypoLength}.");

            Console.ReadLine();
        }
    }
}
