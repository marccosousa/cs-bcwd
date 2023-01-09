namespace uri1115
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' '); 
            int x = int.Parse(s[0]);
            int y = int.Parse(s[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro"); 
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo"); 
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro"); 
                }
                else
                {
                    Console.WriteLine("quarto"); 
                }

                s = Console.ReadLine().Split(' ');
                x = int.Parse(s[0]);
                y = int.Parse(s[1]);
            }
        }
    }
}
