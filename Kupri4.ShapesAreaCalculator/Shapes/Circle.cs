using Kupri4.ShapesAreaCalculator.Shapes.ValueTypes;

namespace Kupri4.ShapesAreaCalculator.Shapes;

public class Circle : Shape
{
    public UDouble Radius { get; set; }
    public Circle(double radius)
    {
        Radius = (UDouble)radius;
    }
    public override double Area()
    {
        if (!IsValid())
            throw new InvalidOperationException($"{GetType()} is not possible");

        return Math.PI * Radius * Radius;
    }

    public override bool IsValid() => Radius > 0;
}
