using System;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2022, 11, 9, 7, 0, 0);
            DateTime d2 = new DateTime(2022, 11, 16, 5, 30, 0);
            DateTime d3 = new DateTime(2022, 11, 12, 4, 20, 0);

            Intervalo i1 = new Intervalo(d1, d2);
            Intervalo i2 = new Intervalo(d1, d2);
            Intervalo i3 = new Intervalo(d3, d2);

            Console.WriteLine(i1.TemIntersecao(i3));
            Console.WriteLine(i1.Equals(i2));
            Console.WriteLine(i1.Duracao);
        }
    }
}
