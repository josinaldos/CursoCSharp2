using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseEMetodos {
    class GetESetSegundoExemplo {
        public class CarroOpcional {
           private double desconto = 0.1;
            private string nome;

            public string Nome {
                get {
                    return "Opcional" + nome;
                }

                set {
                    nome = value;
                }
            }
            //propriedade autoimplementada
            public double Desconto { get; set; }

            public double Preco { get; set; }

            public double PrecoComDesconto {
                get {
                    return Preco - (desconto * Preco);
                }
            }

            //criando o construtor personalizado
            public CarroOpcional(string nome, double preco) {
                Nome = nome;
                Preco = preco;
            }
        }

        public static void Execuar() {

            var op = new CarroOpcional("Aerofólio", 1.500);
            var op2 = new CarroOpcional("Ar Condicionado", 3.200);

            Console.WriteLine(op.PrecoComDesconto);
            Console.WriteLine(op2.PrecoComDesconto);

        }
    }
}
