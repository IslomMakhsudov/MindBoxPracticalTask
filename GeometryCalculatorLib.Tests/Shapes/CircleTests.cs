using GeometryCalculatorLib.Shapes;

namespace GeometryCalculatorLib.Tests.Shapes;

[TestFixture]
public class CircleTests
{
    [Test]
    public void GetArea_RadiusIsPositive_ReturnsCorrectCircleArea()
    {
        var circle = new Circle(5);

        var area = circle.GetArea();

        Assert.That(area, Is.EqualTo(Math.PI * 25));
    }

    [Test]
    public void CircleConstructor_RadiusIsNegative_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            var circle = new Circle(-1);
        });
    }
}
