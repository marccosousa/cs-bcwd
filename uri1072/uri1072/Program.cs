namespace uri1072
{
    class Program
    {
        static void Main(string[] args)
        {
            int dentro=0, fora=0;
            int N = int.Parse(Console.ReadLine());
            
            for (int i = 0 ; i < N; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num >= 10 && num <= 20 )
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }
            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
        }
    }
}
