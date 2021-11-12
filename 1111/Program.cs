using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1111
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-oe действ. число:");
            double re1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2-oe действ. число:");
            double re2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1-oe мнимое число:");
            double im1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2-oe мнимое число:");
            double im2 = Convert.ToDouble(Console.ReadLine());
            Complex a = new Complex(re1,im1);
            Complex b = new Complex(re2,im2);
            Complex c = a + b;
            Console.WriteLine("{0} + {1}i", c.Re, c.Im);
            Console.ReadKey();
        }
    }
}
