using System.Runtime.Serialization;

namespace uri1071
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int menor = 0, maior = 0;
            
            if (num1 < num2)
            {
                menor = num1;
                maior = num2; 
            }
            else
            {
                menor = num2;
                maior = num1;
            }
            int soma = 0;   

            for (int i = menor + 1; i < maior; i++)
            {
                if (i % 2 != 0)
                {
                    soma += i; 
                }
            }

            Console.WriteLine(soma);
        }
    }
}

