using System;
using MultiRegras.Customers;

namespace MultiRegras
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new Factory();

            var customer = factory.Create("microsoft");
            var amount = customer.CalcularICMS(10);

            Console.WriteLine(amount);
        }
    }

    public class Factory
    {
        public IImposto Create(string type) =>
            type switch
            {
                "balta" => new Customers.Balta.Imposto(),
                "microsoft" => new Customers.Microsoft.Imposto(),
                "contoso" => new Customers.Contoso.Imposto(),
                _ => throw new ArgumentException("Invalid type", "type")
            };
    }

    // BAD
    public static class Impostos
    {
        public static decimal CalculaICMS(string cliente, decimal valor)
        {
            if (cliente == "balta.io")
                return valor * 2;

            if (cliente == "microsoft")
                return valor * 3;

            if (cliente == "contoso")
                return valor * 4;

            return valor;
        }
    }
}