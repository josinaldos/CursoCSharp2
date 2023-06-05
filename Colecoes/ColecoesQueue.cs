using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    class ColecoesQueue {

        public static void Executar() {

            var fila = new Queue<string>();

            //vamos enfileirar
            fila.Enqueue("Cleiton");
            fila.Enqueue("Carlos");
            fila.Enqueue("Rodrigo");
            fila.Enqueue("Marisa");
            fila.Enqueue("josimar");
            //pegando o primeiro elememnto da fila
            Console.WriteLine(fila.Peek());
            //contando a fila
            Console.WriteLine(fila.Count);

            //removendo a primeira pessoa da fila
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            //verificando quantas pessoas temos na fila
            foreach(var pessoa in fila) {
                Console.WriteLine(pessoa);
            }

        }
    }
}
