using System.Formats.Asn1;

namespace uri1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double PI = 3.141569;
            double raio = double.Parse(Console.ReadLine()); 
            double area = PI * Math.Pow(raio,2);
            Console.WriteLine("A=" + area.ToString("F4"));


        }
    }
}
