using System;
using System.Globalization;
using System.Linq;

namespace Q7
{
    class Cliente
    {
        private string nome;
        private long cpf;
        private DateTime dataNasc;
        private float rendaMensal;
        private char estadoCivil;
        private int dependentes;

        public string Nome
        {
            get { return nome; }
            set { 
                if(value.Length < 5)
                {
                    throw new ArgumentOutOfRangeException("Nome deve conter pelo menos 5 caracteres");
                }

                nome = value; 
            }
        }

        public long Cpf
        {
            get { return cpf; }
            set
            {
                if(value.ToString().Length != 11)
                {
                    throw new ArgumentOutOfRangeException("CPF deve conter exatamente 11 caracteres");
                }

                cpf = value;
            }
        }

        public DateTime DataNasc
        {
            get { return dataNasc; }
            set
            {
                DateTime dataAtual = DateTime.Today;
                int idade = dataAtual.Year - value.Year;

                if (idade < 18)
                {
                    throw new Exception("O cliente deve ter pelo menos 18 anos na data atual");
                }

                dataNasc = value;
            }
        }

        public float RendaMensal
        {
            get { return rendaMensal; }
            set { rendaMensal = value; }
        }

        public char EstadoCivil
        {
            get { return estadoCivil; }
            set
            {
                char[] validos = {'C', 'S', 'V', 'D', 'c', 's', 'v', 'd'};
                if (!validos.Contains(value))
                {
                    throw new Exception("Estado civil deve ser C, S, V ou D (maiusculo ou minusculo)");
                }

                estadoCivil = value;
            }
        }

        public int Dependentes
        {
            get { return dependentes; }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentOutOfRangeException("Dependentes devem ser de 0 a 10");
                }

                dependentes = value;
            }
        }

        public Cliente(string nome, string cpf, string dataNasc, string rendaMensal, string estadoCivil, string dependentes)
        {
            Nome = nome;
            Cpf = long.Parse(cpf);
            DataNasc = DateTime.ParseExact(s: dataNasc, format: "dd/MM/yyyy", provider: new CultureInfo("pt-BR"));
            RendaMensal = float.Parse(rendaMensal, new CultureInfo("pt-BR"));
            EstadoCivil = char.Parse(estadoCivil);
            Dependentes = int.Parse(dependentes);
        }
    }
}
