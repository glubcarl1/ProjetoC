using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {

        public static void Main(String[] args)
        {
            
            //Calcula Baskara
            
            //Variaveis
            double v1, v2, v3;
            double delt, baskara;
            
            //Coleta dados do user
            Console.WriteLine("Entre com o primeiro valor:");
            a = double.Parse(Console.ReadLine()); // ReadLine lê uma linha do fluxo de entrada padrão.
            Console.WriteLine("Entre com o segundo valor:"); // WriteLine grava o terminador de linha atual no fluxo de saída padrão.
            b = double.Parse(Console.ReadLine()); // Double.Parse converte a representação de seqüência de caracteres de um número para o seu número de ponto flutuante de precisão dupla equivalente.
            Console.WriteLine("Entre com o terceiro valor:"); // WriteLine grava o terminador de linha atual no fluxo de saída padrão.
            c = double.Parse(Console.ReadLine()); // Double.Parse converte a representação de seqüência de caracteres de um número para o seu número de ponto flutuante de precisão dupla equivalente.


            //Logica da operação
            if (v1 == 0 && v2 == 0 && v3 == 0)
            {
                Console.WriteLine("v1, v2 e v3 diferente de 0!"); // WriteLine grava o terminador de linha atual no fluxo de saída padrão.
            }
            else
            {
                delta = Math.Pow(v2, 2) * (-4 * v1 * v3); // Math.Pow retorna um número especificado elevado à potência especificada.
                if (delt < 0)
                {
                    Console.WriteLine("Delt não pode ser menor que 0!"); // WriteLine grava o terminador de linha atual no fluxo de saída padrão.
                }
                else if (delt == 0)
                {
                    baskara = -v2 / (2 * v1);
                }
                else
                {
                    baskara = -b + Math.Sqrt(delt) / (2 * v1); // Math.Sqrt Retorna a raiz quadrada de um número especificado.
                    Console.WriteLine(String.Format("1º Valor da Equação do segundo grau:{0}", baskara)); // WriteLine grava o terminador de linha atual no fluxo de saída padrão.
                    baskara = -b - Math.Sqrt(delt) / (2 * v1); // Math.Sqrt Retorna a raiz quadrada de um número especificado.
                    Console.WriteLine(String.Format("2º Valor da Equação do segundo grau:{0}", baskara)); // WriteLine grava o terminador de linha atual no fluxo de saída padrão.
                }
            }



        }
    }
}
