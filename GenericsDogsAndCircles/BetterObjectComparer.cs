using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDogsAndCircles
{
    public class BetterObjectComparer<T> where T : IComparable<T>
    {
        public T Largest(T a, T b, T c)
        {
            if (a.CompareTo(a) > b.CompareTo(c)) return a;
            else if (b.CompareTo(b) > c.CompareTo(a)) return b;
            else return c;
        }

    }
}
