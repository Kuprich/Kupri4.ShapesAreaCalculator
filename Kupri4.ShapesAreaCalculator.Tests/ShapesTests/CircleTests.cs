using Kupri4.ShapesAreaCalculator.Shapes;

namespace Kupri4.ShapesAreaCalculator.Tests.ShapesTests;

public class CircleTests
{

    [Theory]
    [InlineData(-0.00000000000000001)]
    [InlineData(-999999999)]
    public void Create_circle_failed_when_radius_value_negative(double radius)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
    }

    [Fact]
    public void Create_circle_failed_when_radius_value_equals_0()
    {
        double radius = 0;
        Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
    }

    [Theory]
    [InlineData(5.0)]
    [InlineData(10000)]
    [InlineData(0.00000000000000001)]
    [InlineData(1273812.091823091823)]
    public void Create_circle_succeeds_when_radius_value_positive(double radius)
    {
        var result = new Circle(radius);

        Assert.Equal(radius, result.Radius);
    }

    [Theory]
    [InlineData(5.0)]
    [InlineData(10000)]
    [InlineData(0.00000000000000001)]
    [InlineData(1273812.091823091823)]
    public void Calculate_circle_area(double radius)
    {
        var area = Math.PI * radius * radius;

        var circle = new Circle(radius);

        Assert.Equal(area, circle.Area());
    }

}