using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    class ExerciciosIfElse {
        public static void Executar() {
            /*
            Console.WriteLine("Em que ano você nasceu");
            int ano = int.Parse(Console.ReadLine());

            int idade = 2023 - ano;
            if (idade >= 18 && idade <=70) {
                Console.WriteLine($"Você tem {idade} pode votar");
            } else {
                Console.WriteLine($" Você tem {idade} Não está apto para votar");

    } */

            /*   // Exercicio 2

               Console.WriteLine("Qual é sua senha de acesso");
               string senha = Console.ReadLine();

               if(senha == "7taz9HvJ"){
                   Console.WriteLine("Acesso permitido");
               } else {
                   Console.WriteLine("Acesso negado");
               } */

            /* // Exercicio 3

             Console.WriteLine("Qual a nota do aluno1");
             double n1 = double.Parse(Console.ReadLine());
             Console.WriteLine("Qual é a nota do aluno2");
             double n2 = double.Parse(Console.ReadLine());
             Console.WriteLine("Qual é a nota do aluno3");
             double n3 = double.Parse(Console.ReadLine());

             double  resultado = (n1 + n2 + n3)/3;

             if (resultado >=7) {
                 Console.WriteLine("Aprovado");
             }else if(resultado>=5 && resultado<7) {
                     Console.WriteLine("O aluno está de recuperção");
             } else {
                 Console.WriteLine("Reprovado");
             }*/

            //Exercicio 4

            Console.WriteLine("Qual é a sua altura");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o seu peso");
            double peso = double.Parse(Console.ReadLine());

            double resultado = peso / (altura * altura);

            if (resultado < 18.5) {
                Console.WriteLine("Abaixo do peso");
            } else if (resultado > 18.5 && resultado < 24.9) {
                Console.WriteLine("Peso normal");
            } else if (resultado > 24.9 && resultado < 29.9) {
                Console.WriteLine("Acima do peso");
            } else if (resultado > 29.9 && resultado < 34.9) {
                Console.WriteLine("Obesidade Grau 1");
            } else if (resultado > 34.9 && resultado < 39.9) {
                Console.WriteLine("Obesidade Grau 2");
            } else{
                Console.WriteLine("Obesidade Grau 3");
            }




        }
    }
}
