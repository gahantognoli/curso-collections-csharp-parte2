﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Alura.CursoCollectionParte2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.ReadKey();
        }

        private static void Aula4()
        {
            //List<Mes> meses = new List<Mes>()
            //{
            //    new Mes("Janeiro", 31),
            //    new Mes("Fevereiro", 28),
            //    new Mes("Março", 31),
            //    new Mes("Abril", 30),
            //    new Mes("Maio", 31),
            //    new Mes("Junho", 30),
            //    new Mes("Julho", 31),
            //    new Mes("Agosto", 31),
            //    new Mes("Setembro", 30),
            //    new Mes("Outubro", 31),
            //    new Mes("Novembro", 30),
            //    new Mes("Dezembro", 31)
            //};

            ////Pegar primeiro trimestre
            //var consulta = meses
            //    .Take(3);

            //foreach (var item in consulta)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();

            ////Pegar os meses depois do primeiro trimestre
            //var consulta2 = meses
            //    .Skip(3);

            //foreach (var item in consulta2)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();

            ////Pegar os meses depois do terceiro trimestre
            //var consulta3 = meses
            //    .Skip(6)
            //    .Take(3);

            //foreach (var item in consulta3)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();

            ////Pegar os meses até o mês que comece com a letra 'S'
            //var consulta4 = meses
            //    .TakeWhile(m => !m.Nome.StartsWith("S"));

            //foreach (var item in consulta4)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();

            ////Pular os meses até o mês que comece com a letra 'S'
            //var consulta5 = meses
            //    .SkipWhile(m => !m.Nome.StartsWith("S"));

            //foreach (var item in consulta5)
            //{
            //    Console.WriteLine(item);
            //}

            //Operações LINQ com conjutos
            string[] seq1 = { "janeiro", "fevereiro", "março" };
            string[] seq2 = { "fevereiro", "MARÇO", "abril" };

            Console.WriteLine("Concatenar duas sequências");

            var consulta = seq1.Concat(seq2);

            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("União de duas sequências");
            var consulta2 = seq1.Union(seq2);

            foreach (var item in consulta2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("União de duas sequências com comparador");

            var consulta3 = seq1.Union(seq2, StringComparer.InvariantCultureIgnoreCase);

            foreach (var item in consulta3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Interseção de duas sequências com comparador");

            var consulta4 = seq1.Intersect(seq2);

            foreach (var item in consulta4)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Exceto: elementos de seq1 que não estão em seq2");

            var consulta5 = seq1.Except(seq2);

            foreach (var item in consulta5)
            {
                Console.WriteLine(item);
            }
        }

        private static void Aula3()
        {
            List<Mes> meses = new List<Mes>()
            {
                new Mes("Janeiro", 31),
                new Mes("Fevereiro", 28),
                new Mes("Março", 31),
                new Mes("Abril", 30),
                new Mes("Maio", 31),
                new Mes("Junho", 30),
                new Mes("Julho", 31),
                new Mes("Agosto", 31),
                new Mes("Setembro", 30),
                new Mes("Outubro", 31),
                new Mes("Novembro", 30),
                new Mes("Dezembro", 31)
            };

            //meses.Sort();
            //foreach (var mes in meses)
            //{
            //    if (mes.Dias == 31)
            //    {
            //        Console.WriteLine(mes);
            //    }
            //}

            var consulta = meses
                .Where(m => m.Dias == 31)
                .OrderBy(m => m.Nome)
                .Select(m => m.Nome.ToUpper());

            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }
        }

        private static void Aula2()
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
