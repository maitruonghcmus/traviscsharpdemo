using Nhom20.TravisWithCSharp.Demo;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTest
{
    [TestFixture]
    public class TestClass
    {
        private Calculator _Calculator;

        [SetUp]
        public void Setup()
        {
            _Calculator = new Calculator();
        }

        [TestCase(1, 2, 3)]
        [TestCase(1, 4, 5)]
        [TestCase(3, 2, 5)]
        [TestCase(1, 7, 8)]
        [TestCase(2, 7, 9)]
        public void TestAdd(int a, int b, int result)
        {
            Assert.AreEqual(result, _Calculator.Add(a, b));
        }

        [TestCase(10, 2, 8)]
        [TestCase(11, 4, 7)]
        [TestCase(13, 2, 11)]
        [TestCase(12, 7, 5)]
        public void TestSubtract(int a, int b, int result)
        {
            Assert.AreEqual(result, _Calculator.Subtract(a, b));
        }


        [TestCase(10, 2, 20)]
        [TestCase(12, 3, 36)]
        public void Multiplication(int a, int b, int result)
        {
            Assert.AreEqual(result, _Calculator.Multiplication(a, b));
        }

        [TestCase(12, 2, 6)]
        [TestCase(12, 0, -1)]
        public void Division(int a, int b, int result)
        {
            Assert.AreEqual(result, _Calculator.Division(a, b));
        }
    }
}