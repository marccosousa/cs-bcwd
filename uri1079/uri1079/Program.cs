namespace uri1075
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double num1, num2, num3, media;  
           
            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                num1 = double.Parse(s[0]);
                num2 = double.Parse(s[1]);
                num3 = double.Parse(s[2]);
  
                media = (num1 * 2 + num2 * 3 + num3 * 5) / 10;
                Console.WriteLine(media.ToString("F1"));
            }


        }
    }
}




