namespace MultiRegras.Customers.Balta
{
    public class Imposto : IImposto
    {
        public decimal CalcularICMS(decimal valor) => valor * 2;
    }
}