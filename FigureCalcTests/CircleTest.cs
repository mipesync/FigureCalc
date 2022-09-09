using FigureCalc.Figures;

namespace FigureCalcTests
{
    public class CircleTest
    {
        [Fact]
        public void CircleGetArea_Success()
        {
            //Arrange
            var radius = 10;
            var circle = new Circle(radius);

            //Act
            var correctAre = Math.Round(Math.PI * Math.Pow(radius, 2), 2);

            //Assert
            Assert.Equal(correctAre, circle.GetArea());
        }

        [Fact]
        public void Circle_FailOnWrongData()
        {
            //Arrange
            var radius = 0;
            var exceptionMessage = "Некорректные данные";

            //Act

            //Assert
            Assert.Equal(
                Assert.Throws<ArgumentException>(() => new Circle(radius)).Message,
                exceptionMessage);
        }
    }
}
