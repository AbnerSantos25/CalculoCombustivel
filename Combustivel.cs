namespace CalculoCombustivel
{
    /// <summary>
    /// Classe responsavel por guardar todos os dados do combustivel
    /// </summary>
    public class Combustivel
    {
        public int Id { get; set; }
        public TipoCombustivel TipoCombustivel { get; set; }
        public double ValorGasolina { get; set; }
        public double ValorEtanol { get; set; }

    }
}
