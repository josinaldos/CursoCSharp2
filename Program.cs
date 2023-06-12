using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClasseEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.POO;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis e constatntes - Fundamentos",VariaveisEConstantes.Executar },
                {"Notação Ponto - Fundamentos ",NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos" ,LendoDados.Executar },
                {"Formatando Números - Fundamentos",FormatandoNumeros.Executar },
                {"Operadores Aritméticos - Fundamentos",OperadoresAritmeticos.Executar},
                {"Exercicios - fundamentos",Exercicios.Executar },
                {"Operadores Relacionais - Fundamentos",OperadoresRelacionais.Executar },
                {"Operadores Atribuicao - Fundamentos",OperadoresAtribuicao.Executar },

                //Estruturas de Controle
                {"Estruturas IF -Estruturas de Controle",EstruturasIF.Executar },
                {"Exercicios If Else -Estruturas de Controle",ExerciciosIfElse.Executar },
                {"Estruturas Switch - Estruturas de Controle",EstruturasSwitch.Executar },
                {"Estruturas Wile e For - Estruturas de Controle",EstruturaWlieeFor.Executar },
                {"Exercicio de Repeticao - Estruturas de Controle",ExercicioRepeticao.Executar},
                {"Estrutura for Each - Estruturas de Controle" ,EstruturaForEach.Executar},

                //Classes e Métodos
             {"Membros - Classes e Métodos",Membros.Executar },
             {"Construturores - Classses e Métodos",Construtores.Executar},
             {"Métodos com Retorno - Classes e Métodos",MetodosComRetorno.Executar },
             {"Exercicios Metodos Com Retorno - Classes e Métodos",ExerciciosMetotdosComRetorno.Executar },
             {"Métodos Estáticos - Classes e Métodos",MetodosEstaticos.Executar },
                {"Params - Classes e Métodos",Params.Executar },
                {"Get e Set - Classes e ´Métodos",GetSet.Executar },
                {"Get e Set Segundo Exemplo - Classes e Métosdos",GetESetSegundoExemplo.Execuar },
                {"Exercicio1 Get e Set - Classes e Métodos",Exercicio1GetSet.Executar },
                {"Exercicio 2 Get e Set - Classes e Métodos",Exercicio2GetESet.Executar },
                {"Exercicio 3 Get e Set - Classes e Métodos",Exercicio3GetESet.Executar },

                //Colecões
                {"Arrays - Coleções",Arrays.Executar },
                {"Coleções Queue ",ColecoesQueue.Executar },
                {"Coleções Stack - Colecoes Stack",ColecoesStack.Executar },

                //POO - Programação Orientada a Objetos
                {"Herança - POO",Heranca.Executar },
                {"Construtor This - POO",ConstrutorThis.Executar },
                {"Encapsulamento - POO",POO.Encapsulamento.Executar },
                {"Polimrfismo - POO",Polimorfismo.Executar },
                {"Exercicio Polimorfismo - POO",ExercicioPolimorfismo.Executar }
            });

            central.SelecionarEExecutar();
        }
    }
}