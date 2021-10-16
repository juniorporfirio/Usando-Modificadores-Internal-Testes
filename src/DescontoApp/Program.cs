using System;

namespace DescontoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var desconto = new Desconto();

            var valor = desconto.porValor(1500);
            Console.WriteLine($"Desconto de {valor}");
        }
    }
}
