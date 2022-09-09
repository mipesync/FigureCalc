using FigureCalc.Interfaces;

namespace FigureCalc.Figures
{
    public class Circle : IGetArea
    {
        private double Radius;

        public Circle(double radius)
        {
            if (radius <= 0) throw new ArgumentException("Некорректные данные");

            Radius = radius;
        }

        public double GetArea()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        }
    }
}
