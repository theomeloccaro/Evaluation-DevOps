using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvaluationSampleCode;

namespace TestProject1_vu_avec_cedric
{

    [TestClass]
    public class MathOperationsTests
    {

        [TestMethod]
        [DataRow(2, 3, 5)]
        [DataRow(0, 5, 5)]
        [DataRow(-2, -3, -5)]
        [DataRow(-5, 10, 5)]
        public void Add_WithVariousNumbers_ReturnsCorrectSum(
            int numberOne,
            int numberTwo,
            int expectedResult)
        {
            var math = new MathOperations();

            var result = math.Add(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(10, 2, 5f)]
        [DataRow(5, 2, 2.5f)]
        [DataRow(-10, 2, -5)]
        public void Divide_ValidNumbers_ReturnsCorrectResult(
            int numberOne,
            int numberTwo,
            float expectedResult)
        {
            var math = new MathOperations();

            var result = math.Divide(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Divide_ByZero_ThrowsArgumentException()
        {
            var math = new MathOperations();

            Assert.ThrowsException<ArgumentException>(() => math.Divide(10, 0));
        }

        [TestMethod]
        [DataRow(1, new int[] { 1 })]
        [DataRow(5, new int[] { 1, 3, 5 })]
        [DataRow(10, new int[] { 1, 3, 5, 7, 9 })]
        [DataRow(0, new int[] { })]
        public void GetOddNumbers_WithValidLimit_ReturnsCorrectOddNumbers(
            int limit,
            int[] expectedNumbers)
        {
            var math = new MathOperations();

            var result = math.GetOddNumbers(limit).ToList();

            CollectionAssert.AreEqual(expectedNumbers.ToList(), result);
        }

        [TestMethod]
        public void GetOddNumbers_WithNegativeLimit_ThrowsArgumentException()
        {
            var math = new MathOperations();

            Assert.ThrowsException<ArgumentException>(() => math.GetOddNumbers(-5));
        }
    }
}
