﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturasIF {
        public static void Executar() {


            /* CONVERTENDO TRY PARSE */
            Console.WriteLine("Digite um número:");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            Console.WriteLine($"Resultado: {numero}");

            /*Enquanto o Parse faz a conversão da informação
             * o TryParse verifica se é possível converter para depois
             * fazer a conversão*/

            /*

            Console.WriteLine("Qual é a nota do aluno");
            double n1= double.Parse(Console.ReadLine());
            Console.WriteLine("Qual é a nota do aluno");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual é a nota do aluno");
            double n3 = double.Parse(Console.ReadLine());

            double resultado = (n1+ n2 + n3)/3;

            Console.WriteLine($"A média do aluno é {resultado}");

            if(resultado >= 7) {
                Console.WriteLine("Aluno aprovado");

            } else {
                Console.WriteLine("Aluno reprovado");
            }

            */
        }
    }
}
