namespace uri1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanciaTotal = int.Parse(Console.ReadLine());
            float combustivelGasto = float.Parse(Console.ReadLine()); 
            float consumoMedio = distanciaTotal/combustivelGasto;
            Console.WriteLine(consumoMedio.ToString("F3") + " km/l"); 
        }
    }
}