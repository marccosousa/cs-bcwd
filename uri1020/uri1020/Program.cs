namespace uri1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, resto, anos, meses, dias; 
            num = int.Parse(Console.ReadLine());
            resto = num;

            anos = resto / 365;
            Console.WriteLine(anos + " ano(s)");
            resto = resto % 365;

            meses = resto / 30;
            Console.WriteLine(meses + " mes(es)");
            resto = resto % 30;

            dias = resto;
            Console.WriteLine(dias + " dia(s)");

        }
    }
}
