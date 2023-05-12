using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Exercicios{
        public static void Executar()
        {


            /*
            Console.WriteLine("Qual é a sua nota");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual é a nota2");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual é a nota3");
            double n3 = double.Parse(Console.ReadLine());


            //criar uma variavel para fazer o calculo
            double resultado = (n1 + n2 + n3 )/ 3;
            // tentar exibir as notas
            Console.WriteLine($"A média é {resultado}");

            */

            // (n1 * 3.5 + n2 * 7.5)/11

            /*Console.WriteLine("Qual é a nota n1");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual é a nota n2");
            double n2 = double.Parse(Console.ReadLine());


            double media = (n1 * 3.5 + n2 * 7.5) / 11;
            // tentar exibir as medias
            Console.WriteLine($"A média e{media}"); */

            Console.WriteLine("Qual é numero do funcionario");
            int nf = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o valor da hora");
           int valor= int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o valor do salario");
            double salario = double.Parse(Console.ReadLine());


            double salarioTotal = (valor * salario);

            Console.WriteLine($"O salario do funcionário é {salarioTotal} numero do funcionário{nf}");







        }
    }
}
