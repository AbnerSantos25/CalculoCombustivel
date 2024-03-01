namespace CalculoCombustivel
{
    public class Combustivel
    {
        public int Id { get; set; }
        public TipoCombustivel TipoCombustivel { get; set; }
        public double ValorGasolina { get; set; }
        public double ValorEtanol { get; set; }

        public void imprime()
        {
            if(TipoCombustivel == TipoCombustivel.Flex)
            {
                Console.WriteLine($"Valor da gasolina: {ValorGasolina}, Valor do Etanol: {ValorEtanol}");
            }
            else if(TipoCombustivel == TipoCombustivel.Etanol)
            {
                Console.WriteLine($"Valor da Etanol: " + ValorEtanol);
            }
            else {
                Console.WriteLine($"Valor da gasolina: " + ValorGasolina);
            }

        
        }

    }
}
