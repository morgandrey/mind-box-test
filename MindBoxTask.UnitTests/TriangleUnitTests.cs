using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBoxTask.Task1;

namespace MindBoxTask.UnitTests;

[TestClass]
public class TriangleUnitTests
{
    [TestMethod]
    public void GetArea_SimpleTriangle()
    {
        // Arrange
        var a = 7;
        var b = 4;
        var c = 5;
        var triangle = new Triangle(a, b, c);
        var expectedArea = 9.7979589711327115;
        
        // Act
        var actualArea = triangle.GetArea();
        
        // Assert
        Assert.AreEqual(expectedArea, actualArea);
    }
    
    [TestMethod]
    public void GetArea_RightTriangle()
    {
        // Arrange
        var a = 3;
        var b = 5;
        var c = 4;
        var triangle = new Triangle(a, b, c);
        var expectedArea = 6;
        
        // Act
        var actualArea = triangle.GetArea();
        
        // Assert
        Assert.AreEqual(expectedArea, actualArea);
    }
    
    [TestMethod]
    public void TriangleWithInvalidSides_ThrowsException()
    {
        // Arrange
        var a = 3;
        var b = 12;
        var c = 4;

        // Act
        // Assert
        var exception = Assert.ThrowsException<ArgumentException>(() => new Triangle(a, b, c));
        Assert.AreEqual("Triangle with sides a=3, b=12, c=4 doesn't exist", exception.Message);
    }
}