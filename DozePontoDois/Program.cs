using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DozePontoDois
{
    class Program
    {
        static void Main(string[] args)
        {
            int qntalunos;
            float media, maior=0, menor=10, soma=0;
            
            Console.WriteLine("Quantos alunos tem na turma?");
            qntalunos = int.Parse(Console.ReadLine());
           
            float[] nota = new float[qntalunos];
            for (int i = 0; i < qntalunos; i++)
            {
                Console.WriteLine("Informe a nota do aluno " + i + ": ");
                nota[i] = float.Parse(Console.ReadLine());
                soma = soma + nota[i];
                if (nota[i] > maior)
                {
                    maior = nota[i];
                }
                if (nota[i] < menor)
                {
                    menor = nota[i];
                }
            }
            media = soma / qntalunos;
            Console.WriteLine("A media é: " + media + ".");
            Console.WriteLine("A maior nota é: " + maior + ".");
            Console.WriteLine("A menor nota é: " + menor + ".");


            Console.ReadKey();
            

        }
    }
}
