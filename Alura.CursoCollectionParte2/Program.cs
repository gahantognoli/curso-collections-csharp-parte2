﻿using System;
using System.Collections.Generic;

namespace Alura.CursoCollectionParte2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[,] resultados = new string[3, 4]
            //{
            //    {
            //        "Alemanha", "Espanha", "Itália", "Brasil"
            //    },
            //    {
            //        "Argentina", "Holanda", "França", "Uruguai"
            //    },
            //    {
            //        "Holanda", "Alemanha", "Alemanha", "Portugal"
            //    }
            //};

            //for (int i = 0; i <= resultados.GetUpperBound(1); i++)
            //{
            //    int ano = 2014 - i * 4;
            //    Console.Write(ano.ToString().PadRight(12));
            //}

            //Console.WriteLine();

            //for (int posicao = 0; posicao <= resultados.GetUpperBound(0); posicao++)
            //{
            //    for (int i = 0; i <= resultados.GetUpperBound(1); i++)
            //    {
            //        Console.Write(resultados[posicao, i].PadRight(12));
            //    }
            //    Console.WriteLine();
            //}

            //ARRAY DENTEADO
            string[][] familias = new string[3][];

            familias[0] = new string[] { "Fred", "Wilma", "Pedrita" };
            familias[1] = new string[] { "Homer", "Marge", "Lisa", "Bart", "Maggie" };
            familias[2] = new string[] { "Florida", "Kiko" };


            foreach (var familia in familias)
            {
                Console.WriteLine(string.Join(",", familia));
            }

            Console.ReadKey();
        }

        private static void Aula1()
        {
            //Dicionarios
            //IDictionary<string, Aluno> alunos = new Dictionary<string, Aluno>();
            //alunos.Add("VT", new Aluno("Vanessa", 34672));
            //alunos.Add("AL", new Aluno("Ana", 5617));
            //alunos.Add("RN", new Aluno("Rafael", 17645));
            //alunos.Add("WM", new Aluno("Wanderson", 11287));

            //foreach (var aluno in alunos)
            //{
            //    Console.WriteLine(aluno);
            //}

            //alunos.Remove("AL");
            //alunos.Add("MO", new Aluno("Marcelo", 12345));

            //Console.WriteLine();

            //foreach (var aluno in alunos)
            //{
            //    Console.WriteLine(aluno);
            //}

            //Console.WriteLine("******* SORTED LIST *********");

            //IDictionary<string, Aluno> sorted = new SortedList<string, Aluno>();
            //sorted.Add("VT", new Aluno("Vanessa", 34672));
            //sorted.Add("AL", new Aluno("Ana", 5617));
            //sorted.Add("RN", new Aluno("Rafael", 17645));
            //sorted.Add("WM", new Aluno("Wanderson", 11287));

            //foreach (var aluno in sorted)
            //{
            //    Console.WriteLine(aluno);
            //}

            //Console.WriteLine("******* SORTED DICTIONARY *********");

            //IDictionary<string, Aluno> sorted = new SortedDictionary<string, Aluno>();
            //sorted.Add("VT", new Aluno("Vanessa", 34672));
            //sorted.Add("AL", new Aluno("Ana", 5617));
            //sorted.Add("RN", new Aluno("Rafael", 17645));
            //sorted.Add("WM", new Aluno("Wanderson", 11287));

            //foreach (var aluno in sorted)
            //{
            //    Console.WriteLine(aluno);
            //}

            ISet<string> alunos = new SortedSet<string>(new ComparadorMinusculo())
            {
                "Vanessa Tonini",
                "Ana Losnak",
                "Rafael Nercessian",
                "Priscila Stuani"
            };

            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");
            alunos.Add("Fabio Gushiken");
            alunos.Add("FABIO GUSHIKEN");


            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            //Operações com conjuntos
            ISet<string> outroConjunto = new HashSet<string>();
            alunos.IsSubsetOf(outroConjunto);

            alunos.IsSupersetOf(outroConjunto);

            alunos.SetEquals(outroConjunto);

            alunos.ExceptWith(outroConjunto);

            alunos.IntersectWith(outroConjunto);

            alunos.SymmetricExceptWith(outroConjunto);

            alunos.UnionWith(outroConjunto);
        }
    }
}