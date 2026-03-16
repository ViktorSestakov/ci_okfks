using System.ComponentModel;
using System.Drawing;
using GeometryShape;

namespace Test
{
    public class TestCI
    {
        [Fact]
        public void CreateRectangle()
        {
            GeometryShape.Rectangle rec = new GeometryShape.Rectangle();
            Assert.NotNull(rec);
        }

        [Fact]
        public void CreateTriangle()
        {
            GeometryShape.Triangle tri = new GeometryShape.Triangle();
            Assert.NotNull(tri);
        }

        [Fact]
        public void RectangleArea_check()
        {
            GeometryShape.Rectangle rectangle = new GeometryShape.Rectangle();

            rectangle.Width = 10;
            rectangle.Height = 2;

            double res = rectangle.Area();

            Assert.Equal(res, 20);
        }

        [Fact]
        public void RectangleArea_checkException() // комментарий для пуллреквеста в репу
        {
            GeometryShape.Rectangle rectangle = new GeometryShape.Rectangle();

            rectangle.Width = 0;
            rectangle.Height = -2;

            var ex = Assert.Throws<ArgumentException>(() => rectangle.Area());

            Assert.Contains("Недопустимые числа!", ex.Message.ToString());
        }

        [Fact]
        public void RectanglePerimetre_check()
        {
            GeometryShape.Rectangle rectangle = new GeometryShape.Rectangle();

            rectangle.Width = 10;
            rectangle.Height = 2;

            double res = rectangle.Perimeter();

            Assert.Equal(res, 24);
        }

        [Fact]
        public void RectanglePerimetre_checkException()
        {
            GeometryShape.Rectangle rectangle = new GeometryShape.Rectangle();

            rectangle.Width = 0;
            rectangle.Height = -2;

            var ex = Assert.Throws<ArgumentException>(() => rectangle.Perimeter());

            Assert.Contains("Недопустимые числа!", ex.Message.ToString());
        }
    }
}