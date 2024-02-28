namespace CalculoCombustivel
{
    public class Carro
    {
        public int Id { get; set; } 
        public TipoCombustivel Tipo { get; set; }
        public double ConsumoEtanol { get; set; }
        public double ConsumoGasolina { get; set; }

        public void imprime()
        {
            Console.WriteLine("G: " + ConsumoGasolina);
            Console.WriteLine("A: " + ConsumoEtanol);
        }
    }
}
