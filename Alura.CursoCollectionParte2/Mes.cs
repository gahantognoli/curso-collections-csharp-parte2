using System;

namespace Alura.CursoCollectionParte2
{
    public class Mes //: IComparable
    {
        public Mes(string nome, int dias)
        {
            Nome = nome;
            Dias = dias;
        }

        public string Nome { get; private set; }
        public int Dias { get; private set; }

        //public int CompareTo(object obj)
        //{
        //    if (obj == null)
        //        return -1;

        //    var mes = obj as Mes;

        //    return this.Nome.CompareTo(mes.Nome);
        //}

        public override string ToString()
        {
            return $"[Nome: {Nome} - Dias: {Dias}]";
        }
    }
}
