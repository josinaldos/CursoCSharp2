using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;

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
                {"Estruturas Wile e For - Estruturas de Controle",EstruturaWlieeFor.Executar }
                
            });

            central.SelecionarEExecutar();
        }
    }
}