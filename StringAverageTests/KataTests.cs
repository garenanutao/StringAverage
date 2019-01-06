using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringAverage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAverage.Solution
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void AverageStringSampleTests()
        {
            Kata kata = new Kata();
            Assert.AreEqual("four", kata.AverageString("zero nine five two"));
            Assert.AreEqual("three", kata.AverageString("four six two three"));
            Assert.AreEqual("three", kata.AverageString("one two three four five"));
            Assert.AreEqual("four", kata.AverageString("five four"));
            Assert.AreEqual("zero", kata.AverageString("zero zero zero zero zero"));
            Assert.AreEqual("two", kata.AverageString("one one eight one"));
            Assert.AreEqual("n/a", kata.AverageString(""));
        }
    }
}