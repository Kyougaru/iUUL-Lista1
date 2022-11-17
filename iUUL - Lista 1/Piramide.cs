using System;

namespace iUUL___Lista_1
{
    public class Piramide
    {
        private int n;

        public int N
        {
            get { return n; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("n deve ser > 0");
                }

                n = value;
            }
        }

        public Piramide(int n)
        {
            N = n;
        }

        public void Desenha()
        {
            int tamanho = (n * 2) - 1;

            for(int i = 0; i <= n; ++i)
            {
                for (int j = i - tamanho; j < i; ++j)
                {
                    if(j > 0)
                    {
                        Console.Write(j);
                    } else
                    {
                        Console.Write(" ");
                    }
                }
                for (int j = i; j >= 1; --j)
                {
                    Console.Write(j);
                }
                Console.Write("\n");
            }
        }
    }
}
