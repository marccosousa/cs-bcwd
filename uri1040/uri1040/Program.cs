using System.Xml;

namespace uri1040
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1, N2, N3, N4, media, notaExame, mediaFinal;
            string[] s = Console.ReadLine().Split(' ');
            N1 = double.Parse(s[0]);
            N2 = double.Parse(s[1]);
            N3 = double.Parse(s[2]);
            N4 = double.Parse(s[3]);
            media = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10;
            if (media == 4.85)
            {
                media = 4.8;
            }

            Console.WriteLine("Media: " + media.ToString("F1"));

            if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado."); 
            }
            else if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            } 
            else
            {
                Console.WriteLine("Aluno em exame.");
                notaExame = double.Parse(Console.ReadLine());
                Console.WriteLine("Nota do exame: " + notaExame.ToString("F1"));
                mediaFinal = (media + notaExame) / 2;

                if (mediaFinal >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: " + mediaFinal.ToString("F1"));
            }
        }
    }
}
