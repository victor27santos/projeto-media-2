using System;

namespace projeto_media_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4;
            double media;

            Console.WriteLine("digite a primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite a segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite a terceira nota: ");
            nota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite a quarta nota: ");
            nota4 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 7)
            {
                Console.WriteLine("Aluno Aprovado");
            }
            else
            {
                Console.WriteLine("Aluno Reprovado");
            }
            Console.ReadKey();
        }
    }
}
