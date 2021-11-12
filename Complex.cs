using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Complex
    {
        private double re;
        private double im;
        public double Re
        {
            get
            {
                return re;
            }
        }
        public double Im
        {
            get
            {
                return im;
            }
        }

        public static Complex operator+(Complex a, Complex b)
        {
            Complex c = new Complex();
            c.re = a.re + b.re;
            c.im = a.im + b.im;
            return c;
        }

        public static Complex operator/(Complex a, Complex b)
        {
            try
            {
                if(b.re == 0 && b.im == 0)
                {
                    Exception e = new Exception();
                    throw e;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ты мудак, на ноль делить нельзя!");
            }
            return new Complex();
        }
    }
}
