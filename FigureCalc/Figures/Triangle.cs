using FigureCalc.Interfaces;

namespace FigureCalc.Figures
{
    public class Triangle : IGetArea
    {
        private List<double> Args = new List<double>();

        public Triangle(double ab, double bc, double ca)
        {
            if (Validate(ab, bc, ca)) 
                Args.AddRange(new double[] { ab, bc, ca });
        }

        private bool Validate(double ab, double bc, double ca)
        {
            if (ab <= 0 || bc <= 0 || ca <= 0) throw new ArgumentException("Некорректные данные");

            if (ab + bc < ca || bc + ca < ab || ab + ca < bc) throw new ArgumentException("Не является треугольником.");

            return true;
        }

        public double GetArea()
        {
            var semi_p = Args.Sum() / 2;
            var correctArea = Math.Sqrt(semi_p * (semi_p - Args[0]) * (semi_p - Args[1]) * (semi_p - Args[2]));

            return Math.Round(correctArea, 2);
        }

        public bool IsRight()
        {
            Args.Sort();

            return Math.Pow(Args[2], 2) == Math.Pow(Args[0], 2) + Math.Pow(Args[1], 2);
        }
    }
}
