namespace uri1036
{
    class Program
    {
        static void Main(string[] args)
        {
            double r1, r2;
            string[] s = Console.ReadLine().Split(' '); 
            double a = double.Parse(s[0]);
            double b = double.Parse(s[1]);
            double c = double.Parse(s[2]);
            double delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta < 0 || a == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                r1 = (-b + Math.Sqrt(delta)) / (2 * a);
                r2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("R1 = " + r1.ToString("F5"));
                Console.WriteLine("R2 = " + r2.ToString("F5"));
            }
        }
    }
}
