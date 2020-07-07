using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.CursoCollectionParte2
{
    public class Aluno
    {
        public Aluno(string nome, int numeroMatricula)
        {
            Nome = nome;
            NumeroMatricula = numeroMatricula;
        }

        public string Nome { get; set; }
        public int NumeroMatricula { get; set; }

        public override string ToString()
        {
            return $"[Aluno: {Nome}, matricula: {NumeroMatricula}]";
        }
    }
}
