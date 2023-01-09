namespace uri1117
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            double soma = 0;
            
            while (i < 2)
            {
                double nota = double.Parse(Console.ReadLine());

                while (nota < 0 || nota > 10)
                {
                    Console.WriteLine("nota invalida");
                    nota = double.Parse(Console.ReadLine());
                }
                soma += nota; 
                i++;
            }

            double media = soma / 2;
            Console.WriteLine("media = " + media.ToString("F2"));
        }
    }
}