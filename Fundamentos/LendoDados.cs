using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine("Qual o seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual sua idade");
            // fazendo a conversão de um inteiro
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a sua altura");
            double altura = double.Parse(Console.ReadLine());

            //tentar exibir as 
            Console.WriteLine("Olá tudo bem" + nome + " qual a sua idade" + idade + ", e sua altura" + altura);
        }
    }
}
