using System.Net.Http.Headers;

namespace uri1060
{
    class Program
    {
        static void Main(string[] args)
        {
            int positivos = 0;
            double soma = 0.0;

            for (int i = 1; i <= 6; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (num > 0)
                {
                    positivos++;
                    soma += num; 
                }
            }
            double media = soma / positivos;

            Console.WriteLine(positivos + " valores positivos");
            Console.WriteLine(media.ToString("F1"));  ;
        }
    }
}

