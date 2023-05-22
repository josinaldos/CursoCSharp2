using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    class ExercicioRepeticao {

        public static void Executar() {


            /*
            int soma = 0;

            for (int contador = 1; contador <= 10; contador++) {
                Console.WriteLine("Digite um numero");
                int.TryParse(Console.ReadLine(), out int valor);

                soma += valor;
            }

            Console.WriteLine($"A soma foi de:{soma} ");
            */



            /*
            Console.WriteLine("Digite um numero");
            int.TryParse(Console.ReadLine(), out int numero);


            for(int contador = 1; contador <= numero; contador++) {
                Console.WriteLine(contador);

            */

                Console.WriteLine("Leia um numero");
                int.TryParse(Console.ReadLine(), out int valor);
                for(int contador = 1;contador <= 10; contador++) {

                Console.WriteLine($"{valor} X {contador} = {valor * contador}");

                //3 x 1 = 3
                // 3 x 2 = 6
                // 2 x 1 = 2
                // 2 X 2 = 4
                // 2 x 3 = 6

                }
               
            }


        }


    }

