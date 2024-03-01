using System.Security.Cryptography.X509Certificates;

namespace CalculoCombustivel
{
    public class Carro
    {
        public int Id { get; set; } 
        public TipoCombustivel Tipo { get; set; }
        public double ConsumoEtanol { get; set; }
        public double ConsumoGasolina { get; set; }
        public double Porcentagem { get; set; }
        public void imprime()
        {
            Console.WriteLine("G: " + ConsumoGasolina);
            Console.WriteLine("A: " + ConsumoEtanol);
        }

        public void Calcular(Combustivel Combustivel)
        {

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
                if (ConsumoGasolina == 0 || ConsumoEtanol == 0)
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
