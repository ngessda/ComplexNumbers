using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1111
{
    public class Complex
    {
        private const double EPS = 0.0000001;
        private const double NULL = 0;
        private double re;
        private double im;
        public double Conj
        {
            get
            {
                return im;
            }
        }
        public Complex()
        {
            re = 0;
            im = 0;
        }
        public Complex(double rem, double imm)
        {
            re = rem;
            im = imm;
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
            c.re = (a.re * b.re) - (a.im * b.im);
            c.im = (a.re * b.im) + (a.im * b.re);
            return c;
        }
        public static Complex operator/(Complex a, Complex b)
        {
            try
            {
                if (a.re == 0 || b.re == 0 || a.im == 0 || a.im == 0) 
                {
                    throw new OwnNullException("Ошибка-ошибка");
                }
            }
            catch(OwnNullException ex)
            {
                throw ex;
            }
            Complex c = new Complex();
            c.re = a.re / b.re;
            c.im = a.im / b.im;
            return c;
        }
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (Math.Abs(re) >= EPS)
            {
                if(Math.Abs(im) > EPS)
                {
                    sb.Append($"{re} + i * {im}");
                }
                else if (Math.Abs(im) < EPS)
                {
                    sb.Append($"{re} - i * {-im}");
                }
            }
            else if (Math.Abs(re) < EPS)
            {
                if (Math.Abs(im) > EPS)
                {
                    sb.Append($" i * {im}");
                }
                else if (Math.Abs(im) < EPS)
                {
                    sb.Append($"- i * {-im}");
                }
            }
            return sb.ToString();
        }
    }
}
