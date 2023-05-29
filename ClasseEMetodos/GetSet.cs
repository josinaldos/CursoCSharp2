using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseEMetodos {
    class GetSet {


        class Cliente {
            /*o modificador PRIVATE vai garantir
             que somente a class Cliente vai ter acesso ao nome*/
            private string nome;

            /*Entretanto havéra momentos em que precisaremos
             tirar esse valor ou abstrair alguma informção
            então usamos Get e Set.
            GET PEGA O VALOR e o SET ENVIAR O VALOR*/

            /*Get e o SET precisam ser IGUAIS ao atributo
             da classe Cliente porém com a primeira letra maiuscula*/
            public string Nome {

                //aqui vamos espcificar as nossas ações
                get {
                    //para pegar o valor de Nome, eu vou usar o return
                    return nome;
                }

                set {
                    /*set vai servir para que eu envie um valor
                     então esse value é o valor que o usuário
                    vai me informar na outra classe*/
                    nome = value;
                }

            }
        }
        public static void Executar() {
            /*vamos instanciar um objeto da nossa classe Cliente*/
            Cliente cliente1 = new Cliente();
            /*Exemplo de Get cliente1.Nome;*/

            //usando o SET para enviar uma informção
            cliente1.Nome = "Cleiton";

            Console.WriteLine(cliente1.Nome);
        }
    }
}
