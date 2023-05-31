using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseEMetodos {
    class Exercicio3GetESet {

        class Animal {
            private string nome;
            private string tipo;

            public string Nome {
                get {
                    return nome;
                } 

                set {
                    nome = value;
                }
            }


            public string Tipo {
                get {
                    return tipo;
                }

                set {

                    if(tipo == "cachorro" || tipo == "gato" || tipo == "ave") {
                        tipo = value;
                    } else {
                        tipo = "ave";
                    }
                }
            }      
        }
        public static void Executar() {
            Animal animal1 = new Animal();

            Console.WriteLine("Digite o nome do animal");
            animal1.Nome = Console.ReadLine();

            Console.WriteLine("Digite o tipo do animal");
            animal1.Tipo = Console.ReadLine();

            Console.WriteLine($"O nome do animal é {animal1.Nome} e o tipo é {animal1.Tipo}");
        }
    }
}
