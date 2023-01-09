namespace uri1113
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int num1 = int.Parse(s[0]);
            int num2 = int.Parse(s[1]);

            while (num1 != num2)
            {
                if (num1 < num2)
                {
                    Console.WriteLine("Crescente"); 
                }
                else
                {
                    Console.WriteLine("Decrescente"); 
                }

                s = Console.ReadLine().Split(' ');
                num1 = int.Parse(s[0]);
                num2 = int.Parse(s[1]);
            }
        }
    }
}
