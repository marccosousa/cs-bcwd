namespace uri1074
{
    class Program
    {
        static void Main(string[] args)
        {
            string posNeg, evenOdd; 
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num > 0)
                {
                    posNeg = "POSITIVE"; 
                }
                else
                {
                    posNeg = "NEGATIVE";
                }

                if (num % 2 == 0)
                {
                    evenOdd = "EVEN";
                }
                else
                {
                    evenOdd = "ODD"; 
                }

                if (num == 0)
                {
                    Console.WriteLine("NULL");
                }
                else
                {
                    Console.WriteLine(evenOdd + " " + posNeg);
                }
            }

        }
    }
}

