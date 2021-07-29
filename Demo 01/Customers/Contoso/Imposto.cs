namespace MultiRegras.Customers.Contoso
{
    public class Imposto : IImposto
    {
        public decimal CalcularICMS(decimal valor) => valor * 3;
    }
}