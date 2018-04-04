using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis
            double a, b, x;

			// Inserir valores do usuário		
			
            Console.WriteLine("Entre com o valor de A:"); // WriteLine grava o terminador de linha atual no fluxo de saída padrão.
            a = double.Parse(Console.ReadLine()); // Double.Parse converte a representação de seqüência de caracteres de um número para o seu número de ponto flutuante de precisão dupla equivalente.
            Console.WriteLine("Entre com o valor de B:"); // WriteLine grava o terminador de linha atual no fluxo de saída padrão.
            b = double.Parse(Console.ReadLine()); // Double.Parse converte a representação de seqüência de caracteres de um número para o seu número de ponto flutuante de precisão dupla equivalente.
			
			// A lógica da operação		
            x = -b / a;
			
			// Mostrar o resultado na tela do usuário
            Console.WriteLine(x); // WriteLine grava o terminador de linha atual no fluxo de saída padrão.
            Console.ReadLine(); // ReadLine lê uma linha do fluxo de entrada padrão.
        }
    }
}
