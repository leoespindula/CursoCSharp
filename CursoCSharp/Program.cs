using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;

namespace CursoCSharp 
{
    class Program
    {
        static void Main(string[] args) 
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>()
            {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferências - Fundamentos", Inferencia.Executar },
                {"Interpolação - Fundamentos", Interpolacao.Executar },
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos", LendoDados.Executar },
                {"Formatando Números - Fundamentos", FormatandoNumero.Executar },
                {"Conversões - Fundamentos", Conversoes.Executar },
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar },
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar },
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar },
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar },
                {"Operadore Ternário - Fundamentos", OperadorTernario.Executar  },
                // Estruturas de Controle
                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar },
                {"Estrutura If/Else - Estruturas de Controle", EstruturaIfElse.Executar },
                {"Estrutura If/Else If - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar },
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar },
                {"Estrututa Do While - Estruturas de Controle", EstruturaDoWhile.Executar },
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar },
                {"Estrutura ForEach - Estruturas de Controle",EstruturaForEach.Executar },
                {"Usando o Break - Estruturas de Controle", UsandoBreak.Executar },
                {"Usando o Continue - Estruturas de Controle", UsandoContinue.Executar },
                // Classes vs Objetos 
                {"Membros - Classes e Métodos", Membros.Executar },
                {"Construtores - Classes e Métodos", Construtores.Executar },
                {"Métodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar },
                {"Métodos Estaticos - Classes e Métodos", MetodosEstaticos.Executar },
                {"Atributos Estáticos - Classes E Métodos", AtributosEstaticos.Executar },
                {"Desafio do Atributo - Classes e Métodos", DesafioAtributo.Executar },
                {"Params - Classes e Métodos", Params.Executar },
                {"Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar },
                {"Get Set - Classes e Métodos", GetSet.Executar },
                {"Propriedades - Classes e Métodos", Props.Executar },
                {"Readonly - lasses e Métodos", Readonly.Executar },
                {"Enum - Classes e Métodos",ExemploEnum.Executar },
                {"Struct - Classes e Métodos", Struct.Executar },
                {"Classe vs Struct - Classes e Métodos", ClassVsStruct.Executar },
                {"Valor vs Referencia - Classes e Métodos", ValorVsReferencia.Executar },
                {"Parâmetros por Referência - Classes e Métodos", ParametrosPorReferencia.Executar },
                {"Parâmetros Padrão - Clases e Métodos", ParametroPadrao.Executar },
                // Coleções
                {"Array - Coleções", ColecaoArray.Executar },
                {"List - Coleções", ColecaoList.Executar },
                {"ArrayList - Coleções", ColecaoArrayList.Executar },
                {"Set - Coleções", ColecaoSet.Executar },
                {"Queue - Coleções", ColecaoQueue.Executar },
                {"Igualdade - Coleções", Igualdade.Executar },
                {"Stack - Coleções", ColecaoStack.Executar },
                {"Dictionary - Coleções", ColecaoDictionary.Executar },



            });

            central.SelecionarEExecutar();
        }
    }
}