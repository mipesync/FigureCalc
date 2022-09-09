using FigureCalc.Figures;

namespace FigureCalcTests
{
    public class TriangleTest
    {
        [Fact]
        public void TrangleGetArea_Success()
        {
            //Arrange
            var Args = new double[] { 10, 16, 20 };
            var triangle = new Triangle(Args[0], Args[1], Args[2]);

            //Act
            var semi_p = Args.Sum() / 2;
            var S = Math.Sqrt(semi_p * (semi_p - Args[0]) * (semi_p - Args[1]) * (semi_p - Args[2]));
            //Assert
            Assert.Equal(Math.Round(S, 2), triangle.GetArea());
        }

        [Fact]
        public void TriangleIsRight_Success()
        {
            //Arrange
            var Args = new double[] { 3, 4, 5 };
            var triangle = new Triangle(Args[0], Args[1], Args[2]);

            //Act
            //Assert
            Assert.True(triangle.IsRight());
        }

        [Fact]
        public void Trianglet_FailOnWrongData()
        {
            //Arrange
            var Args = new double[] { 0, 4, 5 };
            var exceptionMessage = "Некорректные данные";

            //Act
            //Assert
            Assert.Equal(
                Assert.Throws<ArgumentException>(() => new Triangle(Args[0], Args[1], Args[2])).Message,
                exceptionMessage);
        }

        [Fact]
        public void Trianglet_FailIfIsNotATriangle()
        {
            //Arrange
            var Args = new double[] { 2, 40, 10 };
            var exceptionMessage = "Не является треугольником.";

            //Act
            //Assert
            Assert.Equal(
                Assert.Throws<ArgumentException>(() => new Triangle(Args[0], Args[1], Args[2])).Message,
                exceptionMessage);
        }
    }
}
