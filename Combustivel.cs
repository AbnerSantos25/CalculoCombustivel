namespace CalculoCombustivel
{
    public class Combustivel
    {
        public int Id { get; set; }
        public TipoCombustivel TipoCombustivel { get; set; }
        public decimal Valor { get; set; }

        public void Gasolina(int valorGasolina)
        {
            TipoCombustivel = TipoCombustivel.Gasolina;
            Valor = valorGasolina;
        }

        public void imprime()
        {
            Console.WriteLine("Tipo: " + TipoCombustivel);
            Console.WriteLine("Valor: " + Valor);
        }
    }
}
