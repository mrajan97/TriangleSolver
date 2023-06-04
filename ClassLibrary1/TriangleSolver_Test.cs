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
        [Test]
        public void test_AnalyzeTriangle_Isosceles_1()
        {
            // Arrange
            int sideA = 5;
            int sideB = 5;
            int sideC = 9;
            string expectedType = "The triangle is valid and is an ISOSCELES";

            // Act
            string actualType = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual(expectedType, actualType);
        }
        [Test]
        public void test_AnalyzeTriangle_Isosceles_2()
        {
            // Arrange
            int sideA = 10;
            int sideB = 6;
            int sideC = 6;
            string expectedType = "The triangle is valid and is an ISOSCELES";

            // Act
            string actualType = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual(expectedType, actualType);
        }
        [Test]
        public void test_AnalyzeTriangle_Isosceles_3()
        {
            // Arrange
            int sideA = 8;
            int sideB = 5;
            int sideC = 8;
            string expectedType = "The triangle is valid and is an ISOSCELES";

            // Act
            string actualType = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual(expectedType, actualType);
        }
        [Test]
        public void test_AnalyzeTriangle_Scalene_1()
        {
            // Arrange
            int sideA = 8;
            int sideB = 5;
            int sideC = 6;
            string expectedType = "The triangle is valid and is a SCALENE";

            // Act
            string actualType = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual(expectedType, actualType);
        }
        [Test]
        public void test_AnalyzeTriangle_Scalene_2()
        {
            // Arrange
            int sideA = 8;
            int sideB = 10;
            int sideC = 6;
            string expectedType = "The triangle is valid and is a SCALENE";

            // Act
            string actualType = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual(expectedType, actualType);
        }
        [Test]
        public void test_AnalyzeTriangle_Scalene_3()
        {
            // Arrange
            int sideA = 15;
            int sideB = 10;
            int sideC = 12;
            string expectedType = "The triangle is valid and is a SCALENE";

            // Act
            string actualType = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual(expectedType, actualType);
        }
        [Test]
        public void test_AnalyzeTriangle_Scalene_4()
        {
            // Arrange
            int sideA = 17;
            int sideB = 16;
            int sideC = 15;
            string expectedType = "The triangle is valid and is a SCALENE";

            // Act
            string actualType = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual(expectedType, actualType);
        }
        [Test]
        public void test_AnalyzeTriangle_Scalene_5()
        {
            // Arrange
            int sideA = 10;
            int sideB = 8;
            int sideC = 6;
            string expectedType = "The triangle is valid and is a SCALENE";

            // Act
            string actualType = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual(expectedType, actualType);
        }

    }
}
