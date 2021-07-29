namespace MultiRegras.Customers.Microsoft
{
    public class Imposto : IImposto
    {
        public decimal CalcularICMS(decimal valor) => valor * 4;
    }
}