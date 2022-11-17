using System;
using Q2;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Vertice v1 = new Vertice(1, 1);
            Vertice v2 = new Vertice(2, 4);
            Vertice v3 = new Vertice(4, 6);
            Vertice v4 = new Vertice(6, 8);

            Vertice[] v = new Vertice[] { v1, v2, v3 };

            Poligono p1 = new Poligono(v);

            Console.WriteLine(p1.AddVertice(v4));
            Console.WriteLine(p1.RemoveVertice(v4));
            Console.WriteLine(p1.qtdVertices);
        }
    }
}
