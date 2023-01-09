namespace uri1013
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' '); 
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            int c = int.Parse(s[2]);
            int maiorAB = (a + b + Math.Abs(a - b)) / 2; 

            if (maiorAB < c)
            {
                maiorAB = c; 
            }
            
            Console.WriteLine(maiorAB + " eh o maior");


        }
    }
}