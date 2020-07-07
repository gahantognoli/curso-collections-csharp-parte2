using System.Collections.Generic;

namespace Alura.CursoCollectionParte2
{
    internal class ComparadorMinusculo : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, System.StringComparison.InvariantCultureIgnoreCase);
        }
    }
}