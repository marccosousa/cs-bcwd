namespace uri1066
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdPares = 0, qtdImpar = 0, qtdPos = 0, qtdNeg = 0, nulo = 0;

            for (int i = 1; i <= 5; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    qtdPares++;
                } 
                else
                {
                    qtdImpar++;
                }

                if (num == 0)
                {
                    nulo++; 
                } 
                else if (num > 0)
                {
                    qtdPos++;
                }
                else
                {
                    qtdNeg++;
                }
            }

            Console.WriteLine(qtdPares + " valor(es) par(es)");
            Console.WriteLine(qtdImpar + " valor(es) impar(es)");
            Console.WriteLine(qtdPos + " valor(es) positivo(s)");
            Console.WriteLine(qtdNeg + " valor(es) negativo(s)");
        }
    }
}


