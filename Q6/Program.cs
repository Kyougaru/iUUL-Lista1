using System;
using Q5;

namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2020, 5, 16, 7, 0, 0);
            DateTime d2 = new DateTime(2020, 8, 9, 5, 30, 0);
            DateTime d3 = new DateTime(2021, 6, 20, 8, 30, 0);
            DateTime d4 = new DateTime(2021, 10, 12, 4, 20, 0);
            DateTime d5 = new DateTime(2022, 11, 22, 1, 00, 0);
            DateTime d6 = new DateTime(2022, 12, 10, 3, 25, 0);

            Intervalo i1 = new Intervalo(d1, d2);
            Intervalo i2 = new Intervalo(d3, d4);
            Intervalo i3 = new Intervalo(d5, d6);

            Intervalo[] i = new Intervalo[] { i1, i2 };

            ListaIntervalo l = new ListaIntervalo(i);
            l.Add(i3);
            l.Imprime();
        }
    }
}
