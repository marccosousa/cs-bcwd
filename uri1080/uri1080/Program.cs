namespace uri1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior = 0, posMaior = 0; 
            int[] valores = new int[100];

            for (int i = 0; i <= 100; i++)
            {
                valores[i] = int.Parse(Console.ReadLine()); 
                if (i == 0)
                {
                    maior = valores[i];
                    posMaior = i; 
                }
                else
                {
                    if (valores[i] > maior)
                    {
                        maior = valores[i];
                        posMaior = i;
                    }
                }
            }

            Console.WriteLine(maior);
            Console.WriteLine(posMaior + 1);

        }
    }
}





