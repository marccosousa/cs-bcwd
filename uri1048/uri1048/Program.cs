namespace uri1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine());
            double novoSalario=0, reajuste=0, percentual=0; 
            
            if (salario <= 400)
            {
                novoSalario = salario + salario * 0.15;
                reajuste = novoSalario - salario;
                percentual = 15; 
            }
            else if (salario <= 800)
            {
                novoSalario = salario + salario * 0.12;
                reajuste = novoSalario - salario;
                percentual = 12;
            }
            else if (salario <= 1200)
            {
                novoSalario = salario + salario * 0.10;
                reajuste = novoSalario - salario;
                percentual = 10;
            }
            else if (salario <= 2000)
            {
                novoSalario = salario + salario * 0.07;
                reajuste = novoSalario - salario;
                percentual = 7;
            }
            else
            {
                novoSalario = salario + salario * 0.04;
                reajuste = novoSalario - salario;
                percentual = 4;
            }

            Console.WriteLine($"Novo salario: {novoSalario:F2}");
            Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
            Console.WriteLine($"Em percentual: {percentual} %");
        }
    }
}
