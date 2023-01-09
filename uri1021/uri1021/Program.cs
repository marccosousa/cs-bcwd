namespace uri1021
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            int resto, nota, qtdNotasEMoedas, moeda;
            num = double.Parse(Console.ReadLine());
            resto = (int)(num * 100 + 0.5);
            
            Console.WriteLine("NOTAS:");
            nota = 100;
            qtdNotasEMoedas = resto / (nota * 100);
            Console.WriteLine(qtdNotasEMoedas + " nota(s) de R$ 100.00");
            resto = resto % (nota * 100);

            nota = 50;
            qtdNotasEMoedas = resto / (nota * 100);
            Console.WriteLine(qtdNotasEMoedas + " nota(s) de R$ 50.00");
            resto = resto % (nota * 100);

            nota = 20;
            qtdNotasEMoedas = resto / (nota * 100);
            Console.WriteLine(qtdNotasEMoedas + " nota(s) de R$ 20.00");
            resto = resto % (nota * 100);

            nota = 10;
            qtdNotasEMoedas = resto / (nota * 100);
            Console.WriteLine(qtdNotasEMoedas + " nota(s) de R$ 10.00");
            resto = resto % (nota * 100);

            nota = 5;
            qtdNotasEMoedas = resto / (nota * 100);
            Console.WriteLine(qtdNotasEMoedas + " nota(s) de R$ 5.00");
            resto = resto % (nota * 100);

            nota = 2;
            qtdNotasEMoedas = resto / (nota * 100);
            Console.WriteLine(qtdNotasEMoedas + " nota(s) de R$ 2.00");
            resto = resto % (nota * 100);

            Console.WriteLine("MOEDAS:");

            moeda = 100;
            qtdNotasEMoedas = resto / moeda;
            Console.WriteLine(qtdNotasEMoedas + " moeda(s) de R$ 1.00");
            resto = resto % moeda;

            moeda = 50;
            qtdNotasEMoedas = resto / moeda;
            Console.WriteLine(qtdNotasEMoedas + " moeda(s) de R$ 0.50");
            resto = resto % moeda;

            moeda = 25;
            qtdNotasEMoedas = resto / moeda;
            Console.WriteLine(qtdNotasEMoedas + " moeda(s) de R$ 0.25");
            resto = resto % moeda;

            moeda = 10;
            qtdNotasEMoedas = resto / moeda;
            Console.WriteLine(qtdNotasEMoedas + " moeda(s) de R$ 0.10");
            resto = resto % moeda;

            moeda = 5;
            qtdNotasEMoedas = resto / moeda;
            Console.WriteLine(qtdNotasEMoedas + " moeda(s) de R$ 0.05");
            resto = resto % moeda;

            qtdNotasEMoedas = resto; 
            Console.WriteLine(qtdNotasEMoedas + " moeda(s) de R$ 0.01");


        }
    }
}
