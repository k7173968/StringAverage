using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Stringaverage
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = Kata.AverageString("zero nine five two");

           /* Assert.AreEqual("four", Kata.AverageString("zero nine five two"));
            Assert.AreEqual("three", Kata.AverageString("four six two three"));
            Assert.AreEqual("three", Kata.AverageString("one two three four five"));
            Assert.AreEqual("four", Kata.AverageString("five four"));
            Assert.AreEqual("zero", Kata.AverageString("zero zero zero zero zero"));
            Assert.AreEqual("two", Kata.AverageString("one one eight one"));
            Assert.AreEqual("n/a", Kata.AverageString(""));*/
            Assert.AreEqual("n/a", Kata.AverageString("sss four"));
        }
    }
}
