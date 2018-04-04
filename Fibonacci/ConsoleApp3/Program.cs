using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {

        // Função Fibonacci
        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        static void Main()
        {

            // Variavel contar
            int cont;

            //Inserir valor
              Console.WriteLine("Informe a quantidade"); // Grava o terminador de linha atual no fluxo de saída padrão.
            cont = int.Parse(Console.ReadLine()); // Tenta converter

            for (int i = 0; i <=
                cont; i++)
            {
                //Chama e mostra o resultado
                Console.WriteLine(Fibonacci(i));
                Console.ReadLine(); // ReadLine lê uma linha do fluxo de entrada padrão.



            }
        }
    }
}
