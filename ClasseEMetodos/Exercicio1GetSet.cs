using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseEMetodos {
    class Exercicio1GetSet {
        class Pessoa {

            private string nome;
            private double altura;
            private int nascimento;

            public string Nome {
                get {
                    return nome;
                }
                set {
                    nome = value;
                }

            }
             public double Altura {
                get {
                    return altura;
                }
                set {
                    altura = value;
                }

            }
              public int Nascimento {

                get {
                    return nascimento;
                }
                set {
                    nascimento = value;
                }

            }


            public void Imprimir() {
                Console.WriteLine( $"Qual e o{nome} sua {altura} e {nascimento}");
            }

            public int Calculo() {

                return 2023 - nascimento;
            }


        }

        public static void Executar() {

            Pessoa pessoa1 = new Pessoa();

            pessoa1.Nome = "Marcos";
            pessoa1. Altura = 1.85;
            pessoa1.Nascimento = 1976;


            Console.WriteLine($"Seu {pessoa1.Nome} e sua {pessoa1.Altura} e data de {pessoa1.Nascimento} ");
            
            
            


 

          

        }

    }

}

