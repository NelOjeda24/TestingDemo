using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    [TestFixture]
    public class OperationsNUnitTest
    {
        [Test]
        public void Add_ImputNumbers_RerturnNumber()
        {
            // 1. Arrange
          Operations Operations = new Operations();
            var Operation = new Operations();


            // 2. Act
            int result = Operations.Add(2, 5);
        

            // 3. Assert
            Assert.That(result, Is.EqualTo(8));
            
        }

        [Test]
        public void IsEven_InputNumber_ReturnTrue()
        {
            //1. arrange
            Operations operations = new Operations();
            var Operation = new Operations();

            //2. act
            var result = operations.Add(2, 2);

            //3. assert
            Assert.That(result, Is
                .True);
        }
        
    }
}
