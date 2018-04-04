using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Primeiro(string[] args)
        {
           // 10% do Numero esc

            // Variaveis 
            double A;
            double Resultado;
           

            // Logica da operação
            Console.WriteLine("Digite um valor"); // WriteLine grava o terminador de linha atual no fluxo de saída padrão.
            A = double.Parse(Console.ReadLine()); // Double.Parse converte a representação de seqüência de caracteres de um número para o seu número de ponto flutuante de precisão dupla equivalente.

            Resultado = 0.1 *A;
           
            Console.WriteLine(Resultado); // WriteLine grava o terminador de linha atual no fluxo de saída padrão.
            Console.ReadLine(); // ReadLine lê uma linha do fluxo de entrada padrão.
        }
    

    static void Segundo(string[] args)
    {
        
        // X% do Numero escolhido

        // Variaveis 
        double Porcentagem;
        double N;
        double Resultado;


    
            // Logica da operação
            Console.WriteLine("Digite o valor da porcentagem"); // WriteLine grava o terminador de linha atual no fluxo de saída padrão.
            Porcentagem = double.Parse(Console.ReadLine()); // Double.Parse converte a representação de seqüência de caracteres de um número para o seu número de ponto flutuante de precisão dupla equivalente.

            Console.WriteLine("Digite o valor da porcentagemdo numero"); // WriteLine grava o terminador de linha atual no fluxo de saída padrão.
            N = double.Parse(Console.ReadLine()); // Double.Parse converte a representação de seqüência de caracteres de um número para o seu número de ponto flutuante de precisão dupla equivalente.

            Resultado = ((double)Porcentagem/100)*N;

        Console.WriteLine(Resultado); // WriteLine grava o terminador de linha atual no fluxo de saída padrão.
        Console.ReadLine(); // ReadLine lê uma linha do fluxo de entrada padrão.
    }
}
}
