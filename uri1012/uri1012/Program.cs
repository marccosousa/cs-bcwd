namespace uri1012
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lados = Console.ReadLine().Split(' ');
            double A = double.Parse(lados[0]);
            double B = double.Parse(lados[1]);
            double C = double.Parse(lados[2]);

            double areaTriangulo = A * C / 2;
            Console.WriteLine("TRIANGULO: " + areaTriangulo.ToString("F3"));       
            
            double areaCirculo = 3.14159 * Math.Pow(C, 2);
            Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3"));
            
            double areaTrapezio = (A + B) * C / 2;
            Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3"));
            
            double areaQuadrado = Math.Pow(B, 2);
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3"));

            double areaRetangulo = A * B; 
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3"));
        }
    }
}
