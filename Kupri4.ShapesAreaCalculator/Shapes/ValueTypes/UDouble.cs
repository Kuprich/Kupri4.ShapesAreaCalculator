namespace Kupri4.ShapesAreaCalculator.Shapes.ValueTypes;

/// <summary>
/// Unsigned double value
/// </summary>
public struct UDouble
{
    private double _value;


    private static bool IsValid(double value) =>
        value > 0;

    public UDouble(double value)
    {
        if (!IsValid(value))
            throw new ArgumentOutOfRangeException(nameof(value), $"value {value} must be positive");

        _value = value;
    }

    public static implicit operator double(UDouble d) => d._value;

    public static explicit operator UDouble(double d)
    {
        if (d < 0)
            throw new ArgumentOutOfRangeException(nameof(d), "Only positive values allowed");

        return new UDouble(d);
    }

    public static double operator +(UDouble a, UDouble b) => a._value + b._value;
    public static double operator -(UDouble a, UDouble b) => a._value - b._value;
    public static double operator *(UDouble a, UDouble b) => a._value * b._value;
    public static double operator /(UDouble a, UDouble b) => a._value * b._value;

}
