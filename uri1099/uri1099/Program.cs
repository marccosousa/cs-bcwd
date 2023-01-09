namespace uri1099
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                int num1 = int.Parse(s[0]);
                int num2 = int.Parse(s[1]);

                if (num1 > num2)
                {
                    int aux = num1;
                    num1 = num2;
                    num2 = aux; 
                }
                
                int soma = 0;
                for (int j = num1 + 1; j < num2; j++)
                {
                    if (j % 2 != 0)
                    {
                        soma += j;
                    }
                }

                Console.WriteLine(soma);
            }


        }
    }
}
