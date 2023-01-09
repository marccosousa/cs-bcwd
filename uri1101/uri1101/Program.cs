using System.Runtime.Serialization;

namespace uri1101
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int num1 = int.Parse(s[0]);
            int num2 = int.Parse(s[1]);
            
            while (num1 > 0 && num2 > 0)
            {

                if (num1 > num2)
                {
                    int aux = num1;
                    num1 = num2;
                    num2 = aux;
                }
                
                int soma = 0; 
                for (int i = num1; i <= num2; i++)
                {
                    Console.Write(i + " ");
                    soma += i;
                }
                Console.WriteLine("Sum=" + soma);

                s = Console.ReadLine().Split(' ');
                num1 = int.Parse(s[0]);
                num2 = int.Parse(s[1]);

            }


        }
    }
}

