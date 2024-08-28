using GeometryCalculatorLib.Interfaces;

namespace GeometryCalculatorLib;
public class ShapeAreaCalculator
{
    public static double CalculateArea(IShape shape)
    {
        return shape.GetArea();
    }
}
