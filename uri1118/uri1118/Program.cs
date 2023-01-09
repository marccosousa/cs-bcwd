namespace uri1118
{
    class Program
    {
        static void Main(string[] args)
        {
            int continua = 1; 

            while (continua == 1)
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

                Console.WriteLine("novo calculo (1-sim 2-nao)");
                continua = int.Parse(Console.ReadLine());
                
                while (continua < 1 || continua > 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    continua = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
