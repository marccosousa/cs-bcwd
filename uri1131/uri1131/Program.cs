namespace uri1131
{
    class Program
    {
        static void Main(string[] args)
        {
            int continua = 1;
            int qtdGrenal=0, empate=0, vitInter=0, vitGremio=0; 

            while (continua == 1)
            {
                string[] s = Console.ReadLine().Split(' ');
                int golsInter = int.Parse(s[0]);
                int golsGremio = int.Parse(s[1]);

                if (golsInter == golsGremio)
                {
                    empate++; 
                }
                else if (golsInter > golsGremio)
                {
                    vitInter++;
                }
                else
                {
                    vitGremio++;
                }
                qtdGrenal++;
                Console.WriteLine("Novo grenal(1-sim 2-nao)");
                continua = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(qtdGrenal + " grenais");
            Console.WriteLine("Inter:" + vitInter);
            Console.WriteLine("Gremio:" + vitGremio);
            Console.WriteLine("Empates:" + empate);
            if (vitInter > vitGremio)
            {
                Console.WriteLine("Inter venceu mais"); 
            }
            else
            {
                Console.WriteLine("Gremio venceu mais");
            }
        }
    }
}