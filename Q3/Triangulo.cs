using System;
using Q2;

namespace Q3
{
    internal enum TiposTriangulo
    {
        Equilatero,
        Isosceles,
        Escaleno
    }

    public class Triangulo
    {
        private Vertice v1, v2, v3;

        public Vertice V1
        {
            get { return v1; }
            private set { v1 = value; }
        }
        public Vertice V2
        {
            get { return v2; }
            private set { v2 = value; }
        }
        public Vertice V3
        {
            get { return v3; }
            private set { v3 = value; }
        }

        public Triangulo(Vertice v1, Vertice v2, Vertice v3)
        {
            V1 = v1;
            V2 = v2;
            V3 = v3;

            EhTriangulo();
        }

        private double A { 
            get { return v1.Distancia(v2); } 
        }

        private double B { 
            get { return v2.Distancia(v3); } 
        }

        private double C { 
            get { return v3.Distancia(v1); } 
        }

        public double Perimetro
        {
            get { return A + B + C; }
        }

        public Enum Tipo
        {
            get
            {
                if (A == B && B == C)
                {
                    return TiposTriangulo.Equilatero;
                }
                else if (A == B || B == C || C == A)
                {
                    return TiposTriangulo.Isosceles;
                }
                else
                {
                    return TiposTriangulo.Escaleno;
                }
            }
        }

        public double Area
        {
            get { return Math.Sqrt(Perimetro / 2 * (Perimetro / 2 - A) * (Perimetro / 2 - B) * (Perimetro / 2 - C)); }
        }

        public override bool Equals(object obj)
        {
            return obj is Triangulo t &&
                   V1.Equals(t.V1) &&
                   V2.Equals(t.V2) &&
                   V3.Equals(t.V3) &&

                   V1.Equals(t.V2) &&
                   V2.Equals(t.V1) &&
                   V3.Equals(t.V2) &&

                   V1.Equals(t.V3) &&
                   V2.Equals(t.V3) &&
                   V3.Equals(t.V1);
            
        }

        private void EhTriangulo()
        {
            if (!(A < B + C) || !(B < A + C) || !(C < A + B))
            {
                throw new Exception("Nao forma um triangulo");
            }
        }
    }
}
