using System.Xml.Schema;

namespace uri1010
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(" "); 
            int code1 = int.Parse(valores[0]);
            int quantity1 = int.Parse(valores[1]);
            double value1 = double.Parse(valores[2]);

            valores = Console.ReadLine().Split(" ");
            int code2 = int.Parse(valores[0]);
            int quantity2 = int.Parse(valores[1]);
            double value2 = double.Parse(valores[2]);

            var total = quantity1 * value1 + quantity2 * value2;
            Console.WriteLine($"VALOR A PAGAR: R$ {total:F2}");

        }
    }
}
