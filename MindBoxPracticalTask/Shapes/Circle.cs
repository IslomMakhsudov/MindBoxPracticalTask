using GeometryCalculatorLib.Interfaces;

namespace GeometryCalculatorLib.Shapes;
public class Circle : IShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius should be a positive number.");
        Radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}
