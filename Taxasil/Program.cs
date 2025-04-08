using Taxasil;

bool Sair = false;
while (!Sair)
            {
                Console.WriteLine("Digite um valor para Taxar: \n");
                double valor = Convert.ToDouble(Console.ReadLine());

                double produtoTaxado = Taxas.CalcularTaxas(valor);
                Console.WriteLine("Produto Taxado em: " + produtoTaxado + " Faça L \n");

                Console.WriteLine("Quer Sair? Escreva 'Sair'");
                if (Console.ReadLine().Trim().ToUpper() == "Sair")
                {
                    Sair = true;
                }
            }
