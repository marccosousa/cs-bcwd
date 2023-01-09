using System.Xml.Schema;

namespace uri1038
{
    class Program
    {
        static void Main(string[] args)
        {
            double total=0; 
            string[] s = Console.ReadLine().Split(' ');
            int cod = int.Parse(s[0]);
            int quantidade = int.Parse(s[1]);

            if (cod == 1)
            {
                total = quantidade * 4.00;  
            }
            else if (cod == 2)
            {
                total = quantidade * 4.50; 
            }
            else if (cod == 3)
            {
                total = quantidade * 5.00;
            }
            else if (cod == 4)
            {
                total = quantidade * 2.00;
            }
            else if (cod == 5)
            {
                total = quantidade * 1.50;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2"));
        }
    }
}
