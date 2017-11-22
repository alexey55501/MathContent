using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsMathHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WinFormsMathHelper.Tests
{
    [TestClass()]
    public class MyMathTests
    {
        public static MyMath MathObject { get; set; }

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            MathObject = new MyMath();
        }
        [ClassCleanup]
        public static void ClassCleanup()
        {
            MathObject = null;
        }

        [TestMethod()]
        public void factorial_input5_result120()
        {
            // arrange

            var input = 5;

            var expected = 120;

            Debug.WriteLine("Arrange finished");

            // act

            var actual = MathObject.Factorial(input);
            Debug.WriteLine("Act finished");

            // assert
            Assert.AreEqual(expected, actual);
            Debug.WriteLine("Assert finished");
        }

        [TestMethod()]
        public void quadraticequationsolve_minus17minus10_result15()
        {
            // arrange

            var a = -1;
            var b = 7;
            var c = -10;

            var expected = new List<int> { 2, 5 };
            Debug.WriteLine("Arrange finished");

            // act

            var actual = MathObject.QuadraticEquation(a, b, c);

            Debug.Write(actual[0].ToString() + " " + actual[1].ToString());

            Debug.WriteLine("Act finished");

            // assert
            

            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
            Debug.WriteLine("Assert finished");
        }
    }
}