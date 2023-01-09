namespace uri1060
{
    class Program
    {
        static void Main(string[] args)
        {
            int positivos = 0; 

            for (int i=1; i <=6; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (num > 0)
                {
                    positivos++; 
                }
            }

            Console.WriteLine(positivos + " valores positivos");
        }
    }
}
