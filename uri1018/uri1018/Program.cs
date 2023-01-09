namespace uri1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, resto, nota, qtdNotas; 
            num = int.Parse(Console.ReadLine());
            Console.WriteLine(num);
            resto = num;

            nota = 100;
            qtdNotas = resto / nota;
            Console.WriteLine(qtdNotas + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 50;
            qtdNotas = resto / nota;
            Console.WriteLine(qtdNotas + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 20;
            qtdNotas = resto / nota;
            Console.WriteLine(qtdNotas + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 10;
            qtdNotas = resto / nota;
            Console.WriteLine(qtdNotas + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 5;
            qtdNotas = resto / nota;
            Console.WriteLine(qtdNotas + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 2;
            qtdNotas = resto / nota;
            Console.WriteLine(qtdNotas + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 1;
            qtdNotas = resto / nota;
            Console.WriteLine(qtdNotas + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;
        }
    }
}
