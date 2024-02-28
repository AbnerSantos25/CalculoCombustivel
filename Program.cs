namespace CalculoCombustivel
{

    /// <summary>
    /// Classe responsável pela inicialização do sistema
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Ponto de entrada do sistema
        /// </summary>      \
        static void Main()
        {
            int escolha = 1;

            do
            {
                var carro = new Carro();
                var Combustivel = new Combustivel();

                if (escolha != 5)
                    if (escolha < 1 || escolha > 3)
                    {
                        Console.Clear();
                        Console.WriteLine($"O valor digitado não corresonde com as opções disponiveis no menu, tente novamente.");
                    }
                Console.Clear();
                Console.WriteLine("Informe uma opão: ");
                Console.WriteLine("Digite 1 para >>> Calcular Combustivel");
                Console.WriteLine("Digite 2 para >>> Editar Dados");
                Console.WriteLine("Digite 3 para >>> Sair do Programa");

                var result = Console.ReadLine()!;

                if (!int.TryParse(result, out escolha))
                    continue;

                if (escolha == 1)
                {
                    do 
                    {
                        Console.Clear();
                        Console.WriteLine("Infome os dados do carro: ");
                        Console.WriteLine("Tipo de carro: ");
                        Console.WriteLine("1 - GASOLINA");
                        Console.WriteLine("2 - ETANOL");
                        Console.WriteLine("3 - FLEX");
                        Console.WriteLine("4 - Não Informar!");
                        var tipo = Console.ReadLine();
                        if (tipo == "1" || tipo == "2" || tipo == "3" || tipo == "4")
                        {
                            carro.Tipo = Enum.Parse<TipoCombustivel>(tipo);
                            Console.WriteLine(carro.Tipo);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Opção não é Valida!");
                            Task.Delay(1500).Wait();
                            continue;
                        }
                    }                
                    while (true);
                    


                }
                else if (escolha == 2)
                {
                     do 
                    {
                        Console.Clear();
                        Console.WriteLine("Infome os dados do carro: ");
                        Console.WriteLine("Tipo de carro: ");
                        Console.WriteLine("1 - GASOLINA");
                        Console.WriteLine("2 - ETANOL");
                        Console.WriteLine("3 - FLEX");
                        Console.WriteLine("4 - Não Informar!");
                        var tipo = Console.ReadLine();
                        if (tipo == "1" || tipo == "2" || tipo == "3" || tipo == "4")
                        {
                            carro.Tipo = Enum.Parse<TipoCombustivel>(tipo);
                            Console.WriteLine(carro.Tipo);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Opção não é Valida!");
                            Task.Delay(1500).Wait();
                            continue;
                        }
                    }                
                    while (true);

                    do
                    {
                        // Console.Clear();
                        double ValorEtanol = 0;
                        double valorGasolina = 0;

                        Combustivel.TipoCombustivel = carro.Tipo;

                        if(carro.Tipo == TipoCombustivel.Flex)
                        {
                            Console.WriteLine("Informe o valor do Etanol: ");
                            ValorEtanol = double.Parse(Console.ReadLine()!);
                            

                            Console.WriteLine("Informe o valor da Gasolina: ");
                            valorGasolina = double.Parse(Console.ReadLine()!);
                            if(ValorEtanol / carro.ConsumoEtanol < valorGasolina / carro.ConsumoGasolina)
                            {
                                Console.WriteLine("Abasteça com Etanol");
                            }
                            else
                            {
                                Console.WriteLine("Abasteça com Gasolina");
                            }
                            
                        }
                        else if (carro.Tipo == TipoCombustivel.Etanol)
                        {
                            Console.WriteLine("Informe o valor do Etanol: ");
                            Combustivel.Valor = decimal.Parse(Console.ReadLine()!);
                        }
                        else
                        {
                            Console.WriteLine("Informe o valor da Gasolina: ");
                            Combustivel.Valor = decimal.Parse(Console.ReadLine()!);
                        }
                        
                        Combustivel.imprime();
                        escolha = 4; //go back to the main menu
                        break;
                           
                    }
                    while (true);

                }
                else if (escolha == 3)
                {
                    Console.Write("Deseja realmente sair? 4 (sim) 5 (Não)");
                    int sair = int.Parse(Console.ReadLine()!);
                    if (sair == 1)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        escolha = 5;
                        continue;
                    }
                }

            } while (escolha < 1 || escolha > 3);

            var carro1 = new Carro();
            


        }
    }
}
