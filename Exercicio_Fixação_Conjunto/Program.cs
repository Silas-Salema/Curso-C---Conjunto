using System;
using System.Collections.Generic;

namespace Exercicio_Fixação_Conjunto
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.Write("O curso A possui quantos alunos? " );
            int alunos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o código dos aluno do curso A:");
            for (int i = 0; i < alunos; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                A.Add(cod);
            }

            Console.Write("O curso B possui quantos alunos? ");
            alunos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o código dos aluno do curso A:");
            for (int i = 0; i < alunos; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                B.Add(cod);
            }

            Console.Write("O curso C possui quantos alunos? ");
            alunos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o código dos aluno do curso A:");
            for (int i = 0; i < alunos; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                C.Add(cod);
            }

            A.UnionWith(B);
            A.UnionWith(C);

            Console.WriteLine("Total de alunos: " + A.Count);

        }
    }
}
