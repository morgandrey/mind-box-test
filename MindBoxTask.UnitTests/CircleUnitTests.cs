using MindBoxTask.Task1;

namespace MindBoxTask.UnitTests;

using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class CircleUnitTests
{
    [TestMethod]
    public void GetArea_ValidRadius()
    {
        // Arrange
        var radius = 20;
        var circle = new Circle(radius);
        var expected = 1256.6370614359173;

        // Act
        var actualArea = circle.GetArea();

        // Assert
        Assert.AreEqual(expected, actualArea);
    }
    
    [TestMethod]
    public void CircleWithInvalidRadius_ThrowsException()
    {
        // Arrange
        var radius = -20;

        // Act
        // Assert
        var exception = Assert.ThrowsException<ArgumentException>(() => new Circle(radius));
        Assert.AreEqual("Radius can't be negative or zero", exception.Message);
    }
}