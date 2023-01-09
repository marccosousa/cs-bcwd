namespace uri1116
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' '); 
                int x = int.Parse(s[0]);
                int y = int.Parse(s[1]);

                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel"); 
                }
                else
                {
                    double res = (double)x / (double)y;
                    Console.WriteLine(res.ToString("F1"));
                }
            }
        }
    }
}
