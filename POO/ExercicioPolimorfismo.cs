using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.POO {
    class ExercicioPolimorfismo {
       

        public class Cliente {
            //criando atributos

            public string Nome;
            public string Tipo;
        }

        public class Fisico :Cliente {
            public string Cpf;
        }

        public class Juridico : Cliente {
            public string Cnpj;
        }
        
        //usando Polimorfismo

        
        public static void Executar() {

            Cliente pessoa = new Cliente();
            Fisico pessoa1 = new Fisico();
            Juridico pessoa2 = new Juridico();


            Console.WriteLine("Escreva se você é fisico ou juridico");
            pessoa.Tipo = Console.ReadLine();

            if(pessoa.Tipo == "fisico") {
                Console.WriteLine("Digite seu cpf:");
                pessoa1.Cpf = Console.ReadLine();
                Console.WriteLine("Seu nome é "+pessoa1.Cpf);
            } else if (pessoa.Tipo == "juridico") {
                Console.WriteLine("Digite seu cnpj");
                pessoa2.Cnpj = Console.ReadLine();
                Console.WriteLine("Seu cnpj é"+pessoa2.Cnpj);
            } else {
                Console.WriteLine("Código inválido");
            }
        
           

        }
    }
}
