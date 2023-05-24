using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseEMetodos {
    class MetodosComRetorno {

        class CaculadoraComum {

            public int Somar(int a, int b) {
                return a + b;
            }

            public int Subtrair(int a, int b) {
                return a - b;
            }

            public int Multiplicar(int a, int b) {
                return a * b;
            }
        }
        public static void Executar() {
            //instanciando o meu objeto CalculadoraComum
            var calculadoraComum = new CaculadoraComum();
            //chamando o meu método
            var resultado = calculadoraComum.Somar(27, 42);
            Console.WriteLine(resultado);

            Console.WriteLine(calculadoraComum.Subtrair(5,18));
            //chamando outro valor

            var total = calculadoraComum.Multiplicar(27, 42);
            Console.WriteLine(total);

        }
    }
}
