namespace uri1047
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' '); 
            int horaInicial = int.Parse(s[0]);
            int minutoInicial = int.Parse(s[1]);
            int horaFinal = int.Parse(s[2]);
            int minutoFinal = int.Parse(s[3]);
            int tempoInicial = horaInicial * 60 + minutoInicial;
            int tempoFinal = horaFinal * 60 + minutoFinal;
            int duracao = 0; 

            if (tempoFinal > tempoInicial)
            {
                duracao = tempoFinal - tempoInicial; 
            }
            else
            {
                duracao = (24 * 60 - tempoInicial) + tempoFinal;
            }

            int tempoHora = duracao / 60; 
            int tempoMinuto = duracao % 60;

            Console.WriteLine($"O JOGO DUROU {tempoHora} HORA(S) E {tempoMinuto} MINUTO(S)");
        }
    }
}