using System;

namespace Q2
{
    public class Vertice
    {
        private double x;
        private double y;

        public double X
        {
            get{ return x; }
            private set { x = value; }
        }

        public double Y
        {
            get { return y; }
            private set { y = value; }
        }

        public Vertice(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void Move(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double Distancia(Vertice v)
        {
            double a, b, d;

            a = Math.Pow(v.X - X, 2);
            b = Math.Pow(v.Y - Y, 2);

            d = Math.Sqrt(a + b);

            return d;
        }

        public override bool Equals(object obj)
        {
            return obj is Vertice v &&
                   X == v.X &&
                   Y == v.Y;
        }
    }
}
