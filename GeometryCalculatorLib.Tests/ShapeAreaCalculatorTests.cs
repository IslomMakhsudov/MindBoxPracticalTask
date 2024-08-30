using GeometryCalculatorLib.Interfaces;
using GeometryCalculatorLib.Shapes;

namespace GeometryCalculatorLib.Tests;
[TestFixture]
public class ShapeAreaCalculatorTests
{
    [Test]
    public void CalculateArea_ShapeIsCircle_ReturnsCorrectArea()
    {
        IShape circle = new Circle(5);

        var area = ShapeAreaCalculator.CalculateArea(circle);

        Assert.That(area, Is.EqualTo(Math.PI * 25));
    }

    [Test]
    public void CalculateArea_ShapeIsTriangle_ReturnsCorrectArea()
    {
        IShape triangle = new Triangle(3, 4, 5);

        var area = ShapeAreaCalculator.CalculateArea(triangle);

        Assert.That(area, Is.EqualTo(6));
    }
}
