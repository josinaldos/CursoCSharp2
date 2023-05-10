using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {

        public static void Executar()
        {

            /*Console.WriteLine("digite um numero");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("digite outro numero");
            int numero2 = int.Parse(Console.ReadLine());

            int resultado = numero + numero2;

            Console.WriteLine("O resultado é" + resultado);
           
            */

            Console.WriteLine("qual é a base");
            int base1 = int.Parse(Console.ReadLine());

            Console.WriteLine("qual é a altura");
            int altura = int.Parse(Console.ReadLine());

            int resultado = (base1 * altura) / 2; 

            Console.WriteLine($"O resultado é {resultado}");







        }
    }
}
