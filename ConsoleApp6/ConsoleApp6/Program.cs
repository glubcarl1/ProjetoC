using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//VER SE NUMERO É PAR OU IMPAR
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
                   // VARIAVEIS
            int N;
            int Resultado_numero;
            Console.WriteLine("escreva um nuemro desejado"); // WriteLine grava o terminador de linha atual no fluxo de saída padrão.
            N = int.Parse(Console.ReadLine()); // Tenta converter
            Resultado_numero = N % 2;
             // CONDIÇÃO DE PARA SER IMPAR
            if (Resultado_numero == 1)
            {
                Console.WriteLine("Numero impar"); // WriteLine grava o terminador de linha atual no fluxo de saída padrão.
            }
            // CONDIÇÃO PARA SER PAR
            else
            {
                Console.WriteLine("Numero è par"); // WriteLine grava o terminador de linha atual no fluxo de saída padrão.
            };
            // RESULTADO DA OPERAÇÃO
            Console.WriteLine(Resultado_numero); // WriteLine grava o terminador de linha atual no fluxo de saída padrão.
            Console.ReadLine(); // ReadLine lê uma linha do fluxo de entrada padrão.
        }
}
}
