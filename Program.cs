using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float alunos, peso, media, t = 0;
            int i = 1;

            Console.Write("Quantos alunos tem em sua academia ? : ");
            alunos = float.Parse(Console.ReadLine());

            do
            {
                Console.Write($"Qual o peso do aluno {i} : ");
                peso = float.Parse(Console.ReadLine());
                i++;
                t = t + peso;
            }
            while (i <= alunos);

            media = t / alunos;
            Console.WriteLine($"A média de peso dos alunos é: {media}");
            Console.ReadKey();
        }
    }
}
