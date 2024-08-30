using GeometryCalculatorLib.Interfaces;

namespace GeometryCalculatorLib;
public static class ShapeAreaCalculator
{
    public static double CalculateArea(IShape shape)
    {
        return shape.GetArea();
    }
}
