using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.POO {
    class Heranca {

        //criar classe carro

        public class Carro {
            protected readonly int VelocidadeMaxima;
            //a variavel velocidadeMaxima será transmitida por herança
            //por isso que estamos usando o protected
            int VelocidadeAtual;

            //criando o construtor de carro
            public Carro(int velocidadeMaxima) {
                VelocidadeMaxima = velocidadeMaxima;
            }

            //criando método para acelerar o carro
            protected int  AlterarVelocidade(int delta) {
                int novaVelocidade = VelocidadeAtual + delta;
                if(novaVelocidade < 0) {
                    VelocidadeAtual = 0;

                } else if (novaVelocidade > VelocidadeMaxima) {
                    VelocidadeAtual = VelocidadeMaxima;
                } else {
                    VelocidadeAtual = novaVelocidade;
                }
                return VelocidadeAtual;

                }

            public int Acelerar() {
                return AlterarVelocidade(5);
            }

            public int Frear() {
                return AlterarVelocidade(-5);
            }
            }

        public class Uno : Carro {
            /*o número 200 que está entre base()
             significa a velocidadeMaxima que foi herdado de carro
            usamos base para não precisa fazer o construtor novamente*/
            public Uno() : base(200) {

            }
        }

        //criar uma outra classe que vai herdar

        public class Onix : Carro {
            public Onix() : base(200) {

            }
        }
        public static void Executar() {
            Console.WriteLine("Uno...");
            //instanciar carro1 em Uno
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine("Onix...");
            //instanciar carro2 em Onix
            Onix carro2 = new Onix();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());

        }
    }
}
