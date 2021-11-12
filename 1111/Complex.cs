using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1111
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
            set
            {
                re = value;
            }
        }
        public double Im
        {
            get
            {
                return im;
            }
            set
            {
                im = value;
            }
        }
        public static Complex operator+(Complex a,Complex b)
        {
            Complex c = new Complex();
            c.re = a.re + b.re;
            c.im = a.im + b.im;
            return c;
        }
        public static Complex operator-(Complex a, Complex b)
        {
            Complex c = new Complex();
            c.re = a.re - b.re;
            c.im = a.im - b.im;
            return c;
        }
        public static Complex operator*(Complex a, Complex b)
        {
            Complex c = new Complex();
            c.re = a.re * b.re;
            c.im = a.im * b.im;
            return c;
        }
        public static Complex operator/(Complex a, Complex b)
        {
            try
            {
                if(a.re == 0 && b.re ==0)
                {
                    throw new Exception();
                }
            }
            catch
            {
                throw new Exception(")))))");
            }
            Complex c = new Complex();
            c.re = a.re / b.re;
            c.re = a.im / b.im;
            return c;
        }
    }
}
