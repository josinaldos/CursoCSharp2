using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseEMetodos {
    class Membros {

        public static void Executar() {

            /*instanciando a classe Pessoa
             e criando um objeto pessoal*/

            //Pessoa pessoa1 = new Pessoa();

            //pessoa1.Nome = "Cleiton";
            //pessoa1.Idade = 22;

            // Console.WriteLine($"Olá {pessoa1.Nome} você tem {pessoa1.Idade}");

            //chamando o método Apresentar
            // pessoa1.ApresentarNoConsole();

           

            Jogador jogador1 = new Jogador();

            jogador1.Idade = 21;
            jogador1.Altura = 1.85;
            jogador1.Posicao = "Meia";

            Console.WriteLine($"Olá {jogador1} você tem {jogador1.Idade} e sua {jogador1.Altura}");

            //chamando o método Apresentar
            jogador1.ApresentarNoConsole();


        }
    }
}
