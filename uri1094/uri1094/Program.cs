namespace uri1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] qtdAnimais = new int[N];
            char[] animais = new char[N];
            int qtdCobaias = 0, qtdCoelhos = 0, qtdRatos = 0, qtdSapos = 0; 

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                qtdAnimais[i] = int.Parse(s[0]);
                animais[i] = char.Parse(s[1]); 
            }

            for (int i = 0; i < N; i++)
            {
                qtdCobaias += qtdAnimais[i];

                if (animais[i] == 'C')
                {
                    qtdCoelhos += qtdAnimais[i]; 
                }
                else if (animais[i] == 'R')
                {
                    qtdRatos += qtdAnimais[i];
                }
                else if (animais[i] == 'S')
                {
                    qtdSapos += qtdAnimais[i];
                }
            }

            Console.WriteLine("Total: " + qtdCobaias + " cobaias");
            Console.WriteLine("Total de coelhos: " + qtdCoelhos);
            Console.WriteLine("Total de ratos: " + qtdRatos);
            Console.WriteLine("Total de sapos: " + qtdSapos);

            double percCoelho = (double)qtdCoelhos / (double)qtdCobaias * 100; 
            double percRato = (double)qtdRatos / (double)qtdCobaias * 100;
            double percSapo = (double)qtdSapos / (double)qtdCobaias * 100;

            Console.WriteLine("Percentual de coelhos: " + percCoelho.ToString("F2") + " %");
            Console.WriteLine("Percentual de ratos: " + percRato.ToString("F2") + " %");
            Console.WriteLine("Percentual de sapos: " + percSapo.ToString("F2") + " %");

        }
    }
}






