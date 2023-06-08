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
        public void AnalyzeTriangle_Input5and5and5_OutputEquilateral()
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
        public void AnalyzeTriangle_Input5and5and9_OutputIsosceles()
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
        public void AnalyzeTriangle_Input10and6and6_OutputIsosceles()
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
        public void AnalyzeTriangle_Input8and5and8_OutputIsosceles()
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
        public void AnalyzeTriangle_Input8and5and6_OutputScalene()
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
        public void AnalyzeTriangle_Input8and10and6_OutputScalene()
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
        public void AnalyzeTriangle_Input15and10and10_OutputScalene()
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
        public void AnalyzeTriangle_Input17and16and15_OutputScalene()
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
        public void AnalyzeTriangle_Input10and8and6_OutputScalene()
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

        [Test]
        public void AnalyzeTriangle_Input0and8and6_OutputInvalidTrianglewithOneOrMoreSidesZero()
        {
            // Arrange
            int sideA = 0;
            int sideB = 8;
            int sideC = 6;
            string expectedType = "At least one side of your triangle has a zero length and is thus invalid";

            // Act
            string actualType = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual(expectedType, actualType);
        }

        [Test]
        public void AnalyzeTriangle_Input5and0and0_OutputInvalidTrianglewithOneOrMoreSidesZero()
        {
            // Arrange
            int sideA = 5;
            int sideB = 0;
            int sideC = 0;
            string expectedType = "At least one side of your triangle has a zero length and is thus invalid";

            // Act
            string actualType = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual(expectedType, actualType);
        }

        [Test]
        public void AnalyzeTriangle_Input0and0and0_OutputInvalidTrianglewithOneOrMoreSidesZero()
        {
            // Arrange
            int sideA = 0;
            int sideB = 0;
            int sideC = 0;
            string expectedType = "At least one side of your triangle has a zero length and is thus invalid";

            // Act
            string actualType = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual(expectedType, actualType);
        }

        [Test]
        public void AnalyzeTriangle_Input3and1and1_OutputInvalidTriangle()
        {
            // Arrange
            int sideA = 3;
            int sideB = 1;
            int sideC = 1;
            string expectedType = "A triangle cannot be formed with those numbers";

            // Act
            string actualType = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual(expectedType, actualType);
        }
        [Test]
        public void AnalyzeTriangle_Input3and7and1_OutputInvalidTriangle()
        {
            // Arrange
            int sideA = 3;
            int sideB = 7;
            int sideC = 1;
            string expectedType = "A triangle cannot be formed with those numbers";

            // Act
            string actualType = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual(expectedType, actualType);
        }
        [Test]
        public void AnalyzeTriangle_Input10and2and8_OutputInvalidTriangle()
        {
            // Arrange
            int sideA = 10;
            int sideB = 2;
            int sideC = 8;
            string expectedType = "A triangle cannot be formed with those numbers";

            // Act
            string actualType = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual(expectedType, actualType);
        }

    }
}
