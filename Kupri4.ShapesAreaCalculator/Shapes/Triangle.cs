using Kupri4.ShapesAreaCalculator.Shapes.ValueTypes;

namespace Kupri4.ShapesAreaCalculator.Shapes;

public class Triangle : Shape
{
    public Triangle(double a, double b, double c) => (A, B, C) = ((UDouble)a, (UDouble)b, (UDouble)c);

    public UDouble A { get; }
    public UDouble B { get; }
    public UDouble C { get; }

    public override double Area()
    {
        if (!IsValid())
            throw new InvalidOperationException($"{GetType()} is not possible");

        var p = (A + B + C) / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }

    public override bool IsValid() =>
        (A + B > C) && (B + C > A) && (A + C > B);

    public bool IsRightAngled()
    {
        if ((A * A + B * B == C * C) ||
            (B * B + C * C == A * A) ||
            (C * C + A * A == B * B))
        {
            return true;
        }

        return false;
    }

}
