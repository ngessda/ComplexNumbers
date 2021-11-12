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
            Complex re = new Complex();
            Complex im = new Complex();
            re.Re = re1;
            re.Im = im1;
            im.Re = re2;
            im.Im = im2;
            Console.WriteLine("{0} + {1}i", (re / im).Re, (re / im).Im);
            Console.ReadKey();
        }
    }
}
