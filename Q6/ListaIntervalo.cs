using System;
using System.Collections.Generic;
using System.Linq;
using Q5;

namespace Q6
{
    class ListaIntervalo
    {
        private List<Intervalo> intervalos;

        public ListaIntervalo(Intervalo[] intervalos)
        {
            this.intervalos = new List<Intervalo>();

            foreach (Intervalo i in intervalos)
            {
                this.intervalos.Add(i);
            }
        }

        public void Add(Intervalo intervalo)
        {
            foreach (Intervalo i in intervalos)
            {
                if (i.TemIntersecao(intervalo))
                {
                    throw new Exception("O intervalo tem intersecao com um da lista de intervalos");
                }
            }

            intervalos.Add(intervalo);
        }

        public void Imprime()
        {
            List<Intervalo> listaOrdenada = intervalos.OrderBy(x => x.Inicio).ToList();

            foreach (Intervalo i in listaOrdenada)
            {
                Console.WriteLine(i);
            }
        }
    }
}
