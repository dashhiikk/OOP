using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlab1n2
{
    class Program
    {
        static void Main(string[] args)
        {
            ITime european = new EuropeanTime();
            ITime american = new AmericanTime();

            ITime decEuropean = new AddTail(new AddHead(european, "DDD "), "LLL");
            ITime decAmerican = new AddTail(new AddHead(american, "DDD "), "LLL");


            Console.WriteLine("Европейской формат: " + decEuropean.GetTime());
            Console.WriteLine("Американский формат: " + decAmerican.GetTime());

            Console.ReadLine();
        }
    }

}

