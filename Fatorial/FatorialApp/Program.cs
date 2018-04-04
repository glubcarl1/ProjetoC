using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    class Program
    {

        static void Main(string[] args)
        {
            // Variavel
            int valor;

            // Adiciona valor e guarda na variavel
            Console.WriteLine("Entre com o valor:");
            valor = int.Parse(Console.ReadLine()); // Tenta converter

            // Chama o valor que o usuario digitou e mostra na tela
            Console.WriteLine(Fatorial(valor)); // WriteLine grava o terminador de linha atual no fluxo de saída padrão.
            Console.ReadKey(); //O ReadKey método espera, ou seja, blocos na emissão de thread de ReadKey método, até que uma tecla de função ou o caractere é pressionada.


        }


        // Função fatorial, Logica da operação
        static int Fatorial( int i){
            
               if(i <= 1){
                Fatorial = 1;

               }else{
                (i * Fatorial (i - 1)) ;
                }

          
    }




     }
    }


 

























