using Kupri4.ShapesAreaCalculator.Shapes;

namespace Kupri4.ShapesAreaCalculator.Tests.ShapesTests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(-1, 2, 3)]
        [InlineData(1, -2, 3)]
        [InlineData(1, 2, -3)]
        public void Create_triangle_failed_when_any_parameter_negative(double a, double b, double c)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(a, b, c));
        }

        [Theory]
        [InlineData(0, 2, 3)]
        [InlineData(1, 0, 3)]
        [InlineData(1, 2, 0)]
        public void Create_triangle_failed_when_any_parameter_equals_0(double a, double b, double c)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(a, b, c));
        }


        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(18, 8, 6)]
        [InlineData(9, 15, 3)]
        public void Create_triangle_failed_when_not_possible_perametres(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);

            Assert.False(triangle.IsValid());
        }

        [Theory]
        [InlineData(3, 4, 2)]
        [InlineData(5, 10, 6)]
        [InlineData(4.6676767, 4.6676767, 6)]
        public void Create_triangle_succeeds_when_possible_perametres(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);

            Assert.True(triangle.IsValid());
        }

        [Theory]
        [InlineData(6, 8, 10)]        
        [InlineData(24, 25, 7)]        
        [InlineData(5, 12, 13)]        
        public void Create_right_algled_triangle_succeeds(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);

            Assert.True(triangle.IsValid() && triangle.IsRightAngled());
        }


        [Theory]
        [InlineData(6, 8, 10)]
        [InlineData(24, 25, 7)]
        [InlineData(5, 12, 13)]
        [InlineData(3, 4, 2)]
        [InlineData(5, 10, 6)]
        [InlineData(4.6676767, 4.6676767, 6)]
        public void Calculate_triangle_area(double a, double b, double c)
        {
            var p = (a + b + c) / 2;
            var area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            var triangle = new Triangle(a, b, c);

            Assert.Equal(area, triangle.Area());
        }
    }
}
