using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD;

namespace TDD_Test
{
    [TestClass]
    public class ConversionTest
    {
        [TestMethod]
        public void TestConvertDecimalToHexadecimal()
        {
            // Arrange
            int numBaseInitial = 10;
            int numBaseConvert = 16;
            string number = "10";

            var asignConvert = new TDD.NumberConverter();

            string resultExpected = "a";

            // Act
            var resultActual = asignConvert.ConvertBaseNumbers(numBaseInitial, numBaseConvert, number);

            // Asert
            Assert.AreEqual(resultExpected, resultActual);
        }

        [TestMethod]
        public void TestConvertDecimalToBinary()
        {
            // Arrange
            int numBaseInitial = 10;
            int numBaseConvert = 2;
            string number = "6";

            var asignConvert = new TDD.NumberConverter();

            string resultExpected = "110";

            // Act
            var resultActual = asignConvert.ConvertBaseNumbers(numBaseInitial, numBaseConvert, number);

            // Asert
            Assert.AreEqual(resultExpected, resultActual);
        }

        [TestMethod]
        public void TestConvertHexadecimalToBinary()
        {
            // Arrange
            int numBaseInitial = 16;
            int numBaseConvert = 2;
            string number = "a";

            var asignConvert = new TDD.NumberConverter();

            string resultExpected = "1010";

            // Act
            var resultActual = asignConvert.ConvertBaseNumbers(numBaseInitial, numBaseConvert, number);

            // Asert
            Assert.AreEqual(resultExpected, resultActual);
        }

        [TestMethod]
        public void TestConvertHexadecimalToDecimal()
        {
            // Arrange
            int numBaseInitial = 16;
            int numBaseConvert = 10;
            string number = "c";

            var asignConvert = new TDD.NumberConverter();

            string resultExpected = "12";

            // Act
            var resultActual = asignConvert.ConvertBaseNumbers(numBaseInitial, numBaseConvert, number);

            // Asert
            Assert.AreEqual(resultExpected, resultActual);
        }

        [TestMethod]
        public void TestConvertBinaryToDecimal()
        {
            // Arrange
            int numBaseInitial = 2;
            int numBaseConvert = 10;
            string number = "1110";

            var asignConvert = new TDD.NumberConverter();

            string resultExpected = "14";

            // Act
            var resultActual = asignConvert.ConvertBaseNumbers(numBaseInitial, numBaseConvert, number);

            // Asert
            Assert.AreEqual(resultExpected, resultActual);
        }

        [TestMethod]
        public void TestConvertBinaryToHexadecimal()
        {
            // Arrange
            int numBaseInitial = 2;
            int numBaseConvert = 16;
            string number = "1110";

            var asignConvert = new TDD.NumberConverter();

            string resultExpected = "e";

            // Act
            var resultActual = asignConvert.ConvertBaseNumbers(numBaseInitial, numBaseConvert, number);

            // Asert
            Assert.AreEqual(resultExpected, resultActual);
        }

        [TestMethod]
        public void TestErrorInitialBase()
        {
            // Arrange
            int numBaseInitial = 5;
            int numBaseConvert = 16;
            string number = "1110";

            var asignConvert = new TDD.NumberConverter();

            string resultExpected = "ERROR IN NUMBASE";

            // Act
            var resultActual = asignConvert.ConvertBaseNumbers(numBaseInitial, numBaseConvert, number);

            // Asert
            Assert.AreEqual(resultExpected, resultActual);
        }

        [TestMethod]
        public void TestErrorConvertBase()
        {
            // Arrange
            int numBaseInitial = 10;
            int numBaseConvert = 1;
            string number = "1110";

            var asignConvert = new TDD.NumberConverter();

            string resultExpected = "ERROR IN NUMBASECONVERT";

            // Act
            var resultActual = asignConvert.ConvertBaseNumbers(numBaseInitial, numBaseConvert, number);

            // Asert
            Assert.AreEqual(resultExpected, resultActual);
        }
    }
}
