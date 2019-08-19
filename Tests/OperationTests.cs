using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WPFCalc;

namespace Tests
{
    [TestClass]
    public class OperationTests
    {
        [TestMethod]
        public void Sum_IsIOperation()
        {
            var sum = new Sum();
            Assert.IsTrue(sum is IOperation);
        }

        [TestMethod]
        public void Subtraction_IsIOperation()
        {
            var subtraction = new Subtraction();
            Assert.IsTrue(subtraction is IOperation);
        }

        [TestMethod]
        public void Division_IsIOperation()
        {
            var division = new Division();
            Assert.IsTrue(division is IOperation);
        }

        [TestMethod]
        public void Multiplication_IsIOperation()
        {
            var multiplication = new Multiplication();
            Assert.IsTrue(multiplication is IOperation);
        }

        [TestMethod]
        public void Sum_IsSuming()
        {
            var sum = new Sum();
            var rnd = new Random();
            var a = (Decimal)rnd.NextDouble();
            var b = (Decimal)rnd.NextDouble();
            var result = sum.DoOperation(a, b);
            Assert.AreEqual(a + b, result);
        }

        [TestMethod]
        public void Subtraction_IsSubtracting()
        {
            var subtraction = new Subtraction();
            var rnd = new Random();
            var a = (Decimal)rnd.NextDouble();
            var b = (Decimal)rnd.NextDouble();
            var result = subtraction.DoOperation(a, b);
            Assert.AreEqual(a - b, result);
        }

        [TestMethod]
        public void Multiplication_IsMultiplying()
        {
            var multiplication = new Multiplication();
            var rnd = new Random();
            var a = (Decimal)rnd.NextDouble();
            var b = (Decimal)rnd.NextDouble();
            var result = multiplication.DoOperation(a, b);
            Assert.AreEqual(a * b, result);
        }

        [TestMethod]
        public void Division_IsDividing()
        {
            var division = new Division();
            var rnd = new Random();
            var a = (Decimal)rnd.NextDouble();
            var b = (Decimal)rnd.NextDouble();

            //Can't divide by 0
            while (b == 0)
                b = (Decimal)rnd.NextDouble();

            var result = division.DoOperation(a, b);
            Assert.AreEqual(a / b, result);
        }

        [TestMethod]
        public void DivisionByZero_IsGivingException()
        {
            var division = new Division();
            var rnd = new Random();
            var a = (Decimal)rnd.NextDouble();
            Assert.ThrowsException<DivideByZeroException>(() => division.DoOperation(a, 0));
        }
    }
}
