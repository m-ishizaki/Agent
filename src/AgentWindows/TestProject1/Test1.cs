using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp;

namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void Add_WithPositiveNumbers_ReturnsSum()
        {
            // Arrange
            string a1 = "5";
            string a2 = "3";
            string a3 = "2";
            int expected = 10;

            // Act
            int result = MyClass.Add(a1, a2, a3);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Add_WithNegativeNumbers_ReturnsSum()
        {
            // Arrange
            string a1 = "-5";
            string a2 = "-3";
            string a3 = "-2";
            int expected = -10;

            // Act
            int result = MyClass.Add(a1, a2, a3);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Add_WithMixedSigns_ReturnsSum()
        {
            // Arrange
            string a1 = "10";
            string a2 = "-4";
            string a3 = "-1";
            int expected = 5;

            // Act
            int result = MyClass.Add(a1, a2, a3);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Add_WithZero_ReturnsOtherNumber()
        {
            // Arrange
            string a1 = "0";
            string a2 = "42";
            string a3 = "0";
            int expected = 42;

            // Act
            int result = MyClass.Add(a1, a2, a3);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Add_WithInvalidString_ThrowsFormatException()
        {
            // Arrange
            string a1 = "abc";
            string a2 = "5";
            string a3 = "1";

            // Act
            void Act() => MyClass.Add(a1, a2, a3);

            // Assert
            Assert.Throws<FormatException>(Act);
        }

        [TestMethod]
        public void Add_WithLargeNumbers_ReturnsSum()
        {
            // Arrange
            string a1 = "2147483647";
            string a2 = "0";
            string a3 = "0";
            int expected = 2147483647;

            // Act
            int result = MyClass.Add(a1, a2, a3);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Add_TwoPositiveNumbers_ReturnsSum()
        {
            // Arrange
            string a1 = "5";
            string a2 = "3";
            int expected = 8;

            // Act
            int result = MyClass.Add(a1, a2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Add_TwoNegativeNumbers_ReturnsSum()
        {
            // Arrange
            string a1 = "-5";
            string a2 = "-3";
            int expected = -8;

            // Act
            int result = MyClass.Add(a1, a2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Add_TwoMixedSigns_ReturnsSum()
        {
            // Arrange
            string a1 = "10";
            string a2 = "-4";
            int expected = 6;

            // Act
            int result = MyClass.Add(a1, a2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Add_TwoValuesWithZero_ReturnsOtherNumber()
        {
            // Arrange
            string a1 = "0";
            string a2 = "42";
            int expected = 42;

            // Act
            int result = MyClass.Add(a1, a2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Add_TwoValuesWithInvalidString_ThrowsFormatException()
        {
            // Arrange
            string a1 = "abc";
            string a2 = "5";

            // Act
            void Act() => MyClass.Add(a1, a2);

            // Assert
            Assert.Throws<FormatException>(Act);
        }
    }
}
