using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseEMetodos {
    class ExerciciosMetotdosComRetorno {

        class Conversao {

            public double Dolar(double a) {
                return a / 4.95;
            }

            public double Fahrenheit(double c) {
                return c * 1.8 + 32;

            }
        }
        public static void Executar() {
            //convertendo real em dolar
            var conversao = new Conversao();

           double resultado = conversao.Dolar(20);
            Console.WriteLine(resultado);

            //convertendo Graus Celsius para Fahrenheit

            double total = conversao.Fahrenheit(30);
            Console.WriteLine(total);

        }
        }
    }

