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
            private DateTime nascimento;

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
              public DateTime Nascimento {

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

            public  int Calculo() {
               // return DateTime.Today.Year – Nascimento.Year;
            }


        }

        public static void Executar() {

            Pessoa pessoa1 = new Pessoa();

            pessoa1. Nome = "Marcos";
            pessoa1. Altura = 1.85;
            
            


 

          

        }

    }

}

