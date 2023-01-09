namespace uri1046
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' '); 
            int horaInicial = int.Parse(s[0]);
            int horaFinal = int.Parse(s[1]);
            int duracao = 0; 

            if (horaInicial > horaFinal)
            {
                duracao = 24 - horaInicial + horaFinal;
            }
            else if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24; 
            }

            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
        }
    }
}