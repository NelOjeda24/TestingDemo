using NUnit.Framework;
using System;

namespace MyLibrary
{
    [TestFixture]
    public class OperationsNUnitTest
    {
        [Test]
        public void Add_InputNumbers_ReturnSum()
        {
            // 1. Arrange
            var operations = new Operations(); // Corrección del nombre y uso de la variable

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
            double result = operations.addDecimal(2.5, 3.2);

            // 3. Assert
            Assert.That(result, Is.EqualTo(5.7).Within(0.01)); // Verifica la suma de decimales con tolerancia
        }
    }
}
