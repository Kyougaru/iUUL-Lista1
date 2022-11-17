using System;

namespace Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c = new Cliente("Gabriel", "11111111111", "18/10/2001", "2000,00", "S", "2");
            Console.WriteLine("Nome: " + c.Nome + " CPF: " + c.Cpf + " Data Nasc: " + c.DataNasc +
                " Renda Mensal: " + c.RendaMensal + " Estado Civil: " + c.EstadoCivil +
                " Dependentes: " + c.Dependentes);
        }
    }
}
