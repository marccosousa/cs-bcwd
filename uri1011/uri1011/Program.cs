namespace uri1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159; 
            double raio = double.Parse(Console.ReadLine());
            double volumeDaEsfera = 4.0 * pi * Math.Pow(raio, 3) / 3;
            Console.WriteLine("VOLUME = " + volumeDaEsfera.ToString("F3")); 
        }
    }
}