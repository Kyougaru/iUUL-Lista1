using System;
using Q2;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vertice v1 = new Vertice(1, 1);
            Vertice v2 = new Vertice(1, 3);
            Vertice v3 = new Vertice(3, 1);

            Triangulo t1 = new Triangulo(v1, v2, v3);
            Triangulo t2 = new Triangulo(v1, v2, v3);

            Console.WriteLine(t1.Equals(t2));
            Console.WriteLine(t1.Perimetro);
            Console.WriteLine(t1.Area);
            Console.WriteLine(t1.Tipo);
        }
    }
}
