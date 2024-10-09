using NUnit.Framework;
using System.Collections.Generic;

namespace MyLibrary
{
    [TestFixture]
    public class OperationsNUnitTest
    {
        [Test]
        public void Add_InputNumbers_ReturnSum()
        {
            // 1. Arrange
            var operations = new Operations();

            // 2. Act
            int result = operations.Add(2, 5);

            // 3. Assert
            Assert.That(result, Is.EqualTo(7)); // Verifica que la suma sea correcta
        }

        [Test]
        public void IsEven_InputEvenNumber_ReturnTrue()
        {
            // 1. Arrange
            var operations = new Operations();

            // 2. Act
            bool result = operations.IsEven(4); // Prueba con un número par

            // 3. Assert
            Assert.That(result, Is.True); // Verifica que el resultado sea True para un número par
        }

        [Test]
        public void IsEven_InputOddNumber_ReturnFalse()
        {
            // 1. Arrange
            var operations = new Operations();

            // 2. Act
            bool result = operations.IsEven(5); // Prueba con un número impar

            // 3. Assert
            Assert.That(result, Is.False); // Verifica que el resultado sea False para un número impar
        }

        [Test]
        public void AddDecimal_InputDecimalNumbers_ReturnSum()
        {
            // 1. Arrange
            var operations = new Operations();

            // 2. Act
            double result = operations.AddDecimal(2.5, 3.2); // Corrige el método a "AddDecimal"

            // 3. Assert
            Assert.That(result, Is.EqualTo(5.7).Within(0.01)); // Verifica la suma de decimales con tolerancia
        }




        //[Test]
        //[TestCase(1, 10, new int[] { 2, 4, 6, 8, 10 })]
        //[TestCase(0, 20, new int[] { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 })]
        //[TestCase(-10, 10, new int[] { -10, -8, -6, -4, -2, 0, 2, 4, 6, 8, 10 })]
        //public void GetEvenNumbers_ReturnsCorrectEvenNumbers(int start, int end, int[] expected)
        //{
        //    // 1. Arrange
        //    var operations = new Operations();

        //    // 2. Act
        //    IList<int> actual = operations.GetEvenNumbers(start, end);

        //    // 3. Assert
        //    Assert.That(actual, Is.EqualTo(expected)); // Verifica que los números pares devueltos son correctos
        //}


        [Test]
        public void GetEvenNumbers_ImputRange_ReturnEvenNumbers()
        {
            // 1. Arrange
            Operations operations = new();
            int start = 0;
            int end = 10;

            // 2. Act
            var result = operations.GetEvenNumbers(start, end);

            // 3. Assert
            Assert.That(result, Is.Not.Empty);
            Assert.That(result, Is.Not.Null);
            Assert.That(result[0], Is.TypeOf<int>());
            Assert.That(result, Is.Ordered);
            Assert.That(result, Does.Contain(4));
            Assert.That(result, Is.Unique);
            Assert.That(end - start > 0, Is.Not.Null);
            Assert.That(end - start > 0, Is.True);
            Assert.That
        }
    }
}
