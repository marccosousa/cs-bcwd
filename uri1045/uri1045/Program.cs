using System.Xml;

namespace uri1045
{
    class Program
    {
        static void Main(string[] args) 
        {
            double a=0, b=0, c=0;
            string[] s = Console.ReadLine().Split(' ');
            double n1 = double.Parse(s[0]);
            double n2 = double.Parse(s[1]);
            double n3 = double.Parse(s[2]);

            if (n1 > n2 && n1 > n3)
            {
                a = n1; 
                
                if (n2 > n3)
                {
                    b = n2;
                    c = n3; 
                }
                else
                {
                    c = n2;
                    b = n3; 
                }
            }
            else if (n2 > n3)
            {
                a = n2; 

                if (n1 > n3)
                {
                    b = n1;
                    c = n3; 
                }
                else
                {
                    c = n1;
                    b = n3; 
                }
            }
            else 
            {
                a = n3;  

                if (n1 > n2)
                {
                    b = n1;
                    c = n2; 
                }
                else
                {
                    c = n1;
                    b = n2; 
                }
            }
            
            if (a >= b + c)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if (Math.Pow(a, 2) > Math.Pow(b, 2) + Math.Pow(c, 2))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }
                
                if (a == b && a == c && c == b)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }

        }
    }
}
