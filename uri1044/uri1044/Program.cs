namespace uri1044
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' '); 
            int num1 = int.Parse(s[0]);
            int num2 = int.Parse(s[1]);

            if (num1 % num2 == 0 || num2 % num1 == 0)
            {
                Console.WriteLine("Sao multiplos"); 
            }
            else
            {
                Console.WriteLine("Nao sao multiplos");
            }
        }
    }
}
