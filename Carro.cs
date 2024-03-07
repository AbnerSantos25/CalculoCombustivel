using System.Security.Cryptography.X509Certificates;

namespace CalculoCombustivel
{
    /// <summary>
    /// Classe responsável por calcular o combustivel
    /// </summary>
    public class Carro
    {
        public int Id { get; set; } 
        public TipoCombustivel Tipo { get; set; }
        public double ConsumoEtanol { get; set; }
        public double ConsumoGasolina { get; set; }

        /// <summary>
        /// Metodo responsável por calcular o combustivel e retornar o tipo de combustivel que deve ser abastecido
        /// </summary>
        /// <param name="Combustivel"></param>
        public void Calcular(Combustivel Combustivel)
        {
            double Porcentagem;

            if (Tipo == TipoCombustivel.Etanol)
            {
                Console.WriteLine("Abasteça com Etanol");
            }
            else if (Tipo == TipoCombustivel.Gasolina)
            {
                Console.WriteLine("Abasteça com Gasolina");
            }
            else if (Tipo == TipoCombustivel.Flex)
            {
                if (ConsumoGasolina == 0 && ConsumoEtanol == 0)
                {
                    Porcentagem = 0.7;
                    double res = Combustivel.ValorEtanol / Combustivel.ValorGasolina;
                    if (res > Porcentagem)
                    {
                        Console.WriteLine("Abasteça com Gasolina");
                    }
                    else if (res < Porcentagem)
                    {
                        Console.WriteLine("Abasteça Com Etanol");
                    }

                }
                else
                {
                    Porcentagem = ConsumoEtanol / ConsumoGasolina;
                    double res = Combustivel.ValorEtanol / Combustivel.ValorGasolina;
                    if (res > Porcentagem)
                    {
                        Console.WriteLine("Abasteça com Gasolina");
                    }
                    else if (res < ConsumoGasolina)
                    {
                        Console.WriteLine("Abasteça com Etanol");
                    }
                }
            }
        }
    }
}
