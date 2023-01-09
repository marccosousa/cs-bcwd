namespace uri1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempoGasto = int.Parse(Console.ReadLine());
            int velocidadeMedia = int.Parse(Console.ReadLine());
            double qtdLitros = (double)tempoGasto * (double)velocidadeMedia / 12; 
            Console.WriteLine(qtdLitros.ToString("F3"));

        }
    }
}
