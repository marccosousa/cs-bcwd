namespace uri1133
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                int aux = num1;
                num1 = num2;
                num2 = aux; 
            }

            for (int i = num1 + 1; i < num2; i++)
            {
                if (i % 5 == 2 || i % 5 == 3) 
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
