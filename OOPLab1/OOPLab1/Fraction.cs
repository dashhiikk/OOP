using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab1n1
{
    public class Fraction
    {
        public int numerator;
        public int denominator;
        public Fraction(int Numerator, int Denominator)
        {
            if (Denominator == 0) throw new ArgumentException("Denominator cannot be zero.");
            numerator = Numerator;
            denominator = Denominator;
        }

        public void Reduction() 
        {
            int nod = 1;
            for (int i = Math.Abs(numerator); i > 0; i--)
            {
                if (numerator % i == 0 && denominator % i == 0)
                {
                    nod = i;
                    break;
                }
            }
            numerator /= nod;
            denominator /= nod;
        }

        public string ToString()
        {
            if (denominator == 1)
            {
                return Convert.ToString(numerator);
            }
            if  (numerator % denominator == 0)
            {
                return Convert.ToString(numerator/denominator);
            }
            string rez = Convert.ToString(numerator) + "/" + Convert.ToString(denominator);
            return rez;
        }

        public static Fraction operator +(Fraction obj1, Fraction obj2) 
        {
            Fraction rez;
            if (obj1.denominator != obj2.denominator)
            {
                int znam = obj1.denominator * obj2.denominator;
                rez = new Fraction(obj1.numerator * obj2.denominator + obj2.numerator * obj1.denominator, znam);
                rez.Reduction();
            }
            else
            {
                rez = new Fraction(obj1.numerator + obj2.numerator, obj1.denominator);
            }
            
            rez.Reduction();
            return rez;
        }

        public static Fraction operator -(Fraction obj1, Fraction obj2)
        {
            Fraction rez;
            if (obj1.denominator != obj2.denominator)
            {
                int znam = obj1.denominator * obj2.denominator;
                rez = new Fraction(obj1.numerator * obj2.denominator - obj2.numerator * obj1.denominator, znam);
                rez.Reduction();
            }
            else
            {
                rez = new Fraction(obj1.numerator - obj2.numerator, obj1.denominator);
            }

            rez.Reduction();
            return rez;
        }

        public static bool operator ==(Fraction obj1, Fraction obj2)
        {
            if (obj1.numerator == obj2.numerator && obj1.denominator == obj2.denominator)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Fraction obj1, Fraction obj2)
        {
            if (obj1.numerator == obj2.numerator && obj1.denominator == obj2.denominator)
            {
                return false;
            }
            return true;
        }
        public static bool operator <(Fraction obj1, Fraction obj2)
        {
            double temp1 = Convert.ToDouble(obj1.numerator) / Convert.ToDouble(obj1.denominator);
            double temp2 = Convert.ToDouble(obj2.numerator) / Convert.ToDouble(obj2.denominator);
            if (temp1 < temp2)
            {
                return true;
            }
            return false;
        }
        public static bool operator >(Fraction obj1, Fraction obj2)
        {
            double temp1 = Convert.ToDouble(obj1.numerator) / Convert.ToDouble(obj1.denominator);
            double temp2 = Convert.ToDouble(obj2.numerator) / Convert.ToDouble(obj2.denominator);
            if (temp1 > temp2)
            {
                return true;
            }
            return false;
        }
    }
}

