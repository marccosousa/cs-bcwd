using System.Xml;

namespace uri1042
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            double x = double.Parse(s[0]);
            double y = double.Parse(s[1]);
            double z = double.Parse(s[2]);

            double menor=0, meio=0, maior=0; 

            if (x < y && x < z)
            {
                menor = x; 
                
                if (y < z)
                {
                    meio = y;
                    maior = z;
                } 
                else
                {
                    meio = z;
                    maior = y; 
                }
            }
            else if (y < x && y < z)
            {
                menor = y; 

                if (x < z)
                {
                    meio = x;
                    maior = z; 
                }
                else
                {
                    meio = z;
                    maior = x; 
                }
            }
            else if (z < x && z < y) 
            {
                menor = z; 

                if (x < y)
                {
                    meio = x;
                    maior = y; 
                }
                else
                {
                    meio = y;
                    maior = x; 
                }
            }
            Console.WriteLine(menor);
            Console.WriteLine(meio);
            Console.WriteLine(maior);
            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
