namespace uri1145
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' '); 
            int num1 = int.Parse(s[0]);
            int num2 = int.Parse(s[1]);
            int i = 1; 
            while  (i < num2)
            {
                int j = 1; 
                while (j <= num1)
                {
                    if (j == num1)
                    {
                        Console.Write(i);
                    }
                    else
                    {
                        Console.Write(i + " ");
                    }
                    
                    j++;
                    i++; 
                }
                Console.WriteLine();
            }
        }
    }
}
