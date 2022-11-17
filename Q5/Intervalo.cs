using System;

namespace Q5
{
    public class Intervalo
    {
        private DateTime inicio, fim;

        public DateTime Inicio
        {
            get { return inicio; }
            set { inicio = value; }
        }

        public DateTime Fim
        {
            get { return fim; }
            set { fim = value; }
        }

        public TimeSpan Duracao
        {
            get { return Fim - Inicio; }
        }

        public Intervalo(DateTime inicio, DateTime fim)
        {
            if (inicio > fim)
            {
                throw new Exception("data/hora inicial > data / hora final");
            }

            Inicio = inicio;
            Fim = fim;
        }

        public bool TemIntersecao(Intervalo i)
        {
            if (Inicio <= i.Fim && Fim >= i.Inicio)
            {
                return true;
            }

            return false;
        }

        public override bool Equals(object obj)
        {
            return obj is Intervalo i &&
                   Inicio == i.Inicio &&
                   Fim == i.Fim;

        }
    }
}
