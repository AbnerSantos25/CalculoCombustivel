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
            var carro = new Carro();
            carro.Id = 1;
            var Combustivel = new Combustivel();

            do
            {

                Console.Clear();
                Console.WriteLine("Informe uma opão: ");
                Console.WriteLine("Digite 1 para >>> Calcular Consumo");
                Console.WriteLine("Digite 2 para >>> Editar Dados do Carro");
                Console.WriteLine("Digite 3 para >>> Encerrar Sistema");
                
                var result = Console.ReadLine()!;

                if (!Funcoes.ValidaEntradaInt(result, out escolha))
                {
                    continue;
                }
                else
                {
                    if(escolha < 1 || escolha > 3)
                    {
                        Funcoes.ExibirErro();
                        continue;
                    }   
                }

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
                        var tipo = Console.ReadLine();
                        if (tipo == "1" || tipo == "2" || tipo == "3")
                        {
                            carro.Tipo = Enum.Parse<TipoCombustivel>(tipo);
                            break;
                        }
                        else
                        {
                            Funcoes.ExibirErro();
                            continue;
                        }
                    }                
                    while (true);

                    //calcular o valor do combustivel
                    do
                    {

                        if (carro.Tipo == TipoCombustivel.Flex)
                        {
                            Console.Clear();
                            Console.WriteLine("Informe o valor da Gasolina: ");

                            if(!Funcoes.ValidaEntradaDouble(Console.ReadLine()!, out double recebe))
                            {
                                Console.Clear();
                                continue;
                            }
                            else
                            {
                                Console.Clear();
                                Combustivel.ValorGasolina = recebe;
                            }

                            do
                            {
                                Console.WriteLine("Informe o valor do Etanol: ");

                                if (!Funcoes.ValidaEntradaDouble(Console.ReadLine()!, out recebe))
                                {
                                    Console.Clear();
                                    continue;
                                }
                                else
                                {
                                    Combustivel.ValorEtanol = recebe;
                                }
                                Console.Clear();
                                carro.Calcular(Combustivel);
                                break;

                            } while (true);
                                

                        }
                        else if (carro.Tipo == TipoCombustivel.Etanol)
                        {
                            Console.Clear();
                            carro.Calcular(Combustivel);
                        }
                        else
                        {
                            Console.Clear();
                            carro.Calcular(Combustivel);
                        }
                        Console.WriteLine("Você sera redirecionado para o menu principal em 5 segundos");
                        Task.Delay(5000).Wait();
                        escolha = 4; //go back to the main menu
                        break;

                    }
                    while (true);

                    //fim do calcular valor do combustivel

                }
                else if (escolha == 2)
                {
                    // seleciona o tipo do combustivel //
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Infome os dados do carro: ");
                        Console.WriteLine("Tipo de carro: ");
                        Console.WriteLine("1 - GASOLINA");
                        Console.WriteLine("2 - ETANOL");
                        Console.WriteLine("3 - FLEX");
                        var tipo = Console.ReadLine();
                        if (tipo == "1" || tipo == "2" || tipo == "3")
                        {
                            carro.Tipo = Enum.Parse<TipoCombustivel>(tipo);
                            break;
                        }
                        else
                        {
                            Funcoes.ExibirErro();
                            continue;
                        }
                    }                
                    while (true);

                    // Fim do eleciona o tipo do combustivel //


                    // Imput  do consumo do carro por litro && Calcular o mais vantajoso //
                    do
                    {

                        if (carro.Tipo == TipoCombustivel.Flex)
                        {
                            Console.Clear();
                            Console.WriteLine("Informe o consumo em Gasolina: ");
                            if (!Funcoes.ValidaEntradaDouble(Console.ReadLine()!, out double recebe))
                            {
                                continue;
                            }
                            else
                            {
                                carro.ConsumoGasolina = recebe;
                            }

                            do
                            {
                                Console.Clear();
                                Console.WriteLine("Informe o consumo em Etanol: ");

                                if (!Funcoes.ValidaEntradaDouble(Console.ReadLine()!, out recebe))
                                {
                                    continue;
                                }
                                else
                                {
                                    carro.ConsumoEtanol = recebe;
                                    break;
                                }
                            }while (true);

                        }
                        else if (carro.Tipo == TipoCombustivel.Etanol)
                        {
                            Console.Clear();
                            Console.WriteLine("Informe o consumo em Etanol: ");
                            Combustivel.ValorEtanol = double.Parse(Console.ReadLine()!);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Informe o consumo em Gasolina: ");
                            Combustivel.ValorGasolina = double.Parse(Console.ReadLine()!);
                        }
                        Console.WriteLine("Voltando para o menu principal em 1 segundo");    
                        Task.Delay(1000).Wait();
                        escolha = 4; //go back to the main menu
                        break;
                           
                    }
                    while (true);

                }
                else if (escolha == 3)
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Deseja realmente sair? 4 (sim) 5 (Não)");
                        var _sair = Console.ReadLine();
                        if(!Funcoes.ValidaEntradaInt(_sair!, out int sair))
                        {
                            continue;
                        }
                        if (sair != 4 && sair != 5)
                        {
                            Funcoes.ExibirErro();
                            continue;
                        }
                        else
                        {
                            if (sair == 4)
                            {
                                Environment.Exit(0);
                            }
                            else
                            {
                                escolha = 4;
                                break;
                            }
                        }
                    } while (true);
                }

            } while (escolha < 1 || escolha > 3);





        }       
    }
}
