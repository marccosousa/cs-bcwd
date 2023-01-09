using System.Net.Http.Headers;

namespace uri1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double notaA = double.Parse(Console.ReadLine());
            double notaB = double.Parse(Console.ReadLine());
            double media = (notaA * 3.5 + notaB * 7.5) / 11;
            Console.WriteLine("MEDIA = " + media.ToString("F5"));   
            
        }
    }
}