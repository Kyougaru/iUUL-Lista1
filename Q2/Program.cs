using System;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vertice v1 = new Vertice(1, 2);
            Vertice v2 = new Vertice(5, 6);

            Console.WriteLine(v1.Distancia(v2));
            v2.Move(1,2);
            Console.WriteLine(v1.Equals(v2));
        }
    }
}
