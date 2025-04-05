using MathUtils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RationalTests
{
    [TestClass]
    public class RationalUnitTests
    {
        [TestMethod]
        public void ToString_ShouldReturnProperFraction()
        {
            var r = new Rational(17, 6);
            Assert.AreEqual("17/6", r.ToString());
        }

        [TestMethod]
        public void ToString_ShouldReturnNegativeFraction()
        {
            var r = new Rational(-17, 6);
            Assert.AreEqual("-17/6", r.ToString());
        }

        [TestMethod]
        public void ToString_ShouldHandleNegativeDenominator()
        {
            var r = new Rational(17, -6);
            Assert.AreEqual("-17/6", r.ToString());
        }

        [TestMethod]
        public void ToString_ShouldSimplifyToWholeNumber()
        {
            var r = new Rational(6, 3);
            Assert.AreEqual("2", r.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_ShouldThrowExceptionForZeroDenominator()
        {
            _ = new Rational(6, 0);
        }

        [TestMethod]
        public void Addition_ShouldReturnCorrectResult()
        {
            var r1 = new Rational(1, 2);
            var r2 = new Rational(1, 3);
            var expected = new Rational(5, 6);
            Assert.AreEqual(expected, r1 + r2);
        }

        [TestMethod]
        public void Subtraction_ShouldReturnCorrectResult()
        {
            var r1 = new Rational(3, 4);
            var r2 = new Rational(1, 4);
            var expected = new Rational(1, 2);
            Assert.AreEqual(expected, r1 - r2);
        }

        [TestMethod]
        public void Multiplication_ShouldReturnCorrectResult()
        {
            var r1 = new Rational(2, 3);
            var r2 = new Rational(3, 4);
            var expected = new Rational(1, 2);
            Assert.AreEqual(expected, r1 * r2);
        }

        [TestMethod]
        public void Division_ShouldReturnCorrectResult()
        {
            var r1 = new Rational(2, 3);
            var r2 = new Rational(3, 4);
            var expected = new Rational(8, 9);
            Assert.AreEqual(expected, r1 / r2);
        }

        [TestMethod]
        public void UnaryMinus_ShouldReturnNegativeFraction()
        {
            var r = new Rational(5, 6);
            var expected = new Rational(-5, 6);
            Assert.AreEqual(expected, -r);
        }

        [TestMethod]
        public void Equality_ShouldReturnTrueForEquivalentFractions()
        {
            var r1 = new Rational(2, 3);
            var r2 = new Rational(4, 6);
            Assert.IsTrue(r1 == r2);
        }

        [TestMethod]
        public void Inequality_ShouldReturnTrueForDifferentFractions()
        {
            var r1 = new Rational(2, 3);
            var r2 = new Rational(3, 4);
            Assert.IsTrue(r1 != r2);
        }

        [TestMethod]
        public void LessThan_ShouldReturnTrue()
        {
            var r1 = new Rational(1, 3);
            var r2 = new Rational(1, 2);
            Assert.IsTrue(r1 < r2);
        }

        [TestMethod]
        public void GreaterThan_ShouldReturnTrue()
        {
            var r1 = new Rational(3, 4);
            var r2 = new Rational(1, 2);
            Assert.IsTrue(r1 > r2);
        }

        [TestMethod]
        public void LessThanOrEqual_ShouldReturnTrue()
        {
            var r1 = new Rational(1, 2);
            var r2 = new Rational(1, 2);
            Assert.IsTrue(r1 <= r2);
        }

        [TestMethod]
        public void GreaterThanOrEqual_ShouldReturnTrue()
        {
            var r1 = new Rational(3, 4);
            var r2 = new Rational(1, 2);
            Assert.IsTrue(r1 >= r2);
        }

        [TestMethod]
        public void Constructor_ShouldNormalizeNegativeDenominator()
        {
            var r = new Rational(5, -6);
            var expected = new Rational(-5, 6);
            Assert.AreEqual(expected, r);
        }

        [TestMethod]
        public void ToString_ShouldReturnWholeNumber()
        {
            var r = new Rational(8, 4);
            Assert.AreEqual("2", r.ToString());
        }
    }
}