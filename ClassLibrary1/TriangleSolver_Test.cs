using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;

namespace UnitTest
{
    [TestFixture]
    public class TriangleSolver_Test
    {
       

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void test_AnalyzeTriangle_Equilateral()
        {
            // Arrange
            int sideA = 5;
            int sideB = 5;
            int sideC = 5;
            string expectedType = "The triangle is valid and is an EQUILATERAL";

            // Act
            string actualType = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual(expectedType, actualType);
        }
        
    }
}
