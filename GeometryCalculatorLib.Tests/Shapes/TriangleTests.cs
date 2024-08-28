using GeometryCalculatorLib.Shapes;

namespace GeometryCalculatorLib.Tests.Shapes;

[TestFixture]
public class TriangleTests
{
    [Test]
    public void GetArea_ValidSides_ReturnsCorrectTriangleArea()
    {
        var triangle = new Triangle(3, 4, 5);

        var area = triangle.GetArea();

        Assert.That(area, Is.EqualTo(6));
    }

    [Test]
    public void IsRightTriangle_ValidRightTriangle_ReturnsTrue()
    {
        var triangle = new Triangle(3, 4, 5);

        var isRightTriangle = triangle.IsRightTriangle();

        Assert.That(isRightTriangle, Is.True);
    }

    [Test]
    public void TriangleConstructor_InvalidSides_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            var triangle = new Triangle(1, 2, 3);
        });
    }

    [Test]
    public void TriangleConstructor_NegativeSide_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            var triangle = new Triangle(3, 4, -5);
        });
    }
}
