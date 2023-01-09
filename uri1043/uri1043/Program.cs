namespace uri1043
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            double lado1 = double.Parse(s[0]);
            double lado2 = double.Parse(s[1]);
            double lado3 = double.Parse(s[2]);

            if (lado3 < lado1 + lado2 && lado2 < lado1 + lado3 && lado1 < lado2 + lado3)
            {
                double perimetro = lado1 + lado2 + lado3;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1"));
            }
            else
            {
                double area = (lado1 + lado2) * lado3 / 2;
                Console.WriteLine("Area = " + area.ToString("F1")); 
            }

        }
    }
}
