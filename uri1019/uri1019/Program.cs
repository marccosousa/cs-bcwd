using System.Xml;

namespace uri1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, resto, horas, minutos, segundos; 
            num = int.Parse(Console.ReadLine());
            resto = num; 

            horas = resto / 3600;
            resto = num % 3600;

            minutos = resto / 60;
            resto = resto % 60;

            segundos = resto;

            Console.WriteLine($"{horas}:{minutos}:{segundos}");
            

        }
    }
}
