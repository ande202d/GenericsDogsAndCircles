using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDogsAndCircles
{
    public class EvenBetterObjectComparer
    {

        public T Largest<T>(T a, T b, T c, IComparer<T> comparer)
        {
            if (comparer.Compare(a, a) > comparer.Compare(b, c)) return a;
            else if (comparer.Compare(b, b) > comparer.Compare(a, c)) return b;
            else return c;
        }
    }
}
