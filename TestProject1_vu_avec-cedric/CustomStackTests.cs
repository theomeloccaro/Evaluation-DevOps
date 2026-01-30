using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvaluationSampleCode;

namespace TestProject1_vu_avec_cedric
{
    [TestClass]
    public class CustomStackTests
    {
        [TestMethod]
        public void Count_NewStack_ReturnsZero()
        {
            var stack = new CustomStack();

            var count = stack.Count();

            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void Count_AfterOnePush_ReturnsOne()
        {
            var stack = new CustomStack();

            stack.Push(10);

            Assert.AreEqual(1, stack.Count());
        }

        [TestMethod]
        public void Count_AfterMultiplePushes_ReturnsCorrectCount()
        {
            var stack = new CustomStack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            Assert.AreEqual(3, stack.Count());
        }

        [TestMethod]
        public void Count_AfterPop_Decreases()
        {
            var stack = new CustomStack();
            stack.Push(1);
            stack.Push(2);

            stack.Pop();

            Assert.AreEqual(1, stack.Count());
        }

        [TestMethod]
        public void Push_ThenPop_ReturnsSameValue()
        {
            var stack = new CustomStack();

            stack.Push(42);
            var value = stack.Pop();

            Assert.AreEqual(42, value);
        }

        [TestMethod]
        public void Pop_WithOneElement_ReturnsElement()
        {
            var stack = new CustomStack();
            stack.Push(5);

            var value = stack.Pop();

            Assert.AreEqual(5, value);
        }

        [TestMethod]
        public void Pop_RemovesLastElement()
        {
            var stack = new CustomStack();
            stack.Push(1);
            stack.Push(2);

            var firstPop = stack.Pop();
            var secondPop = stack.Pop();

            Assert.AreEqual(2, firstPop);
            Assert.AreEqual(1, secondPop);
        }

        [TestMethod]
        public void Pop_OnEmptyStack_ThrowsStackCantBeEmptyException()
        {
            var stack = new CustomStack();
            Assert.ThrowsException<CustomStack.StackCantBeEmptyException>(() => stack.Pop());
        }

    }
}
