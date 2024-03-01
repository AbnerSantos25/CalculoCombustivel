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
            var Combustivel = new Combustivel();

            do
            {

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

                    //calcular o valor do combustivel
                    do
                    {

                        if (carro.Tipo == TipoCombustivel.Flex)
                        {
                            Console.WriteLine("Informe o valor da Gasolina: ");
                            Combustivel.ValorGasolina = double.Parse(Console.ReadLine()!);


                            Console.WriteLine("Informe o valor do Etanol: ");
                            Combustivel.ValorEtanol = double.Parse(Console.ReadLine()!);
                            Console.Clear();
                            carro.Calcular(Combustivel);

                        }
                        else if (carro.Tipo == TipoCombustivel.Etanol)
                        {
                            Console.WriteLine("Informe o valor da Etanol: ");
                            Combustivel.ValorEtanol = double.Parse(Console.ReadLine()!);
                            Console.Clear();
                            carro.Calcular(Combustivel);
                        }
                        else
                        {
                            Console.WriteLine("Informe o valor da Gasolina: ");
                            Combustivel.ValorGasolina = double.Parse(Console.ReadLine()!);
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
                        Console.WriteLine("4 - Não Informar!");
                        var tipo = Console.ReadLine();
                        if (tipo == "1" || tipo == "2" || tipo == "3" || tipo == "4")
                        {
                            carro.Tipo = Enum.Parse<TipoCombustivel>(tipo);
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

                    // Fim do eleciona o tipo do combustivel //


                    // Imput  do consumo do carro por litro && Calcular o mais vantajoso //
                    do
                    {

                        if(carro.Tipo == TipoCombustivel.Flex)
                        {
                            Console.WriteLine("Informe o consumo em Gasolina: ");
                            carro.ConsumoGasolina = double.Parse(Console.ReadLine()!);


                            Console.WriteLine("Informe o consumo em Etanol: ");
                            carro.ConsumoEtanol = double.Parse(Console.ReadLine()!);

                        }
                        else if (carro.Tipo == TipoCombustivel.Etanol)
                        {
                            Console.WriteLine("Informe o consumo em Etanol: ");
                            Combustivel.ValorEtanol = double.Parse(Console.ReadLine()!);
                        }
                        else
                        {
                            Console.WriteLine("Informe o consumo em Gasolina: ");
                            Combustivel.ValorGasolina = double.Parse(Console.ReadLine()!);
                        }
                             
                        Task.Delay(1000).Wait();
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

        }
    }
}
