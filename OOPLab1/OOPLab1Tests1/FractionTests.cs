using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPLab1;
using OOPLab1n1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab1.Tests
{
    [TestClass()]
    public class FractionTests
    {
        [TestMethod()]
        public void summa()    {
            Fraction a = new Fraction(1, 3);
            Fraction c = new Fraction(1, 3);Fraction d = new Fraction(2, 3);
            Fraction b = a + c; 

            Assert.IsTrue(b == d);
        }
    }
}