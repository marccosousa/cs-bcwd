using System.Globalization;

namespace uri1051
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine());
            double valorImposto = 0;

            if (salario <= 2000.00)
            {
                valorImposto = 0.0;
            }
            else if (salario <= 3000.00)
            {
                valorImposto = (salario - 2000) * 0.08;

            }
            else if (salario <= 4500.00)
            {
                valorImposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;

            }
            else
            {
                valorImposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (valorImposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + valorImposto.ToString("F2"));
            }
        }
    }
}
