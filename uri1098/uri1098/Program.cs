namespace uri1098
{
    class Program
    {
        static void Main(string[] args)
        {
            double i, j=1; 

            for (i=0; i<=2; i+=0.2)
            {
                Console.WriteLine($"I={i} J={j}");
                Console.WriteLine($"I={i} J={j+1}");
                Console.WriteLine($"I={i} J={j+2}");
                j += 0.2; 
            }
        }
    }
}
