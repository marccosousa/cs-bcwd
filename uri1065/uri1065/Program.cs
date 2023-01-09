namespace uri1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int pares = 0;

            for (int i = 1; i <= 5; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    pares++;
                }
            }

            Console.WriteLine(pares + " valores pares");
        }
    }
}

