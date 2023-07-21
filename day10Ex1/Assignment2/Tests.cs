using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Assignment2
{
    [TestFixture]
    public class Tests
    {
        Calculation c = new Calculation();
        [Test]
        public void testadd()
        {
            int a= c.Add(5, 3);
            Assert.AreEqual(8, a);

        }
        [Test]
        public void testsub()
        {
            int a =c.Subtract(5, 3);
            Assert.AreEqual(2, a);

        }
        [Test]
        public void testmultiply()
        {
            int a=c.Multiply(5, 3);
            Assert.AreEqual(15, a);
        }
        [Test]
        public void testdivide()
        {
            int a= c.Divide(15,3);
            Assert.AreEqual(5, a);
        }
        [Test]
        public void testprime()
        {
            bool s = c.IsPrime(2);
            Assert.AreEqual(true, s);
        }

    }
}
