using System;

namespace Taxasil
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Digite um valor para Taxar: \n");
                double valor = Convert.ToDouble(Console.ReadLine());

                double produtoTaxado = Taxas.CalcularTaxas(valor);
                Console.WriteLine("Produto Taxado em: " + produtoTaxado + " Faça L \n");
            }
        }
    }
}

