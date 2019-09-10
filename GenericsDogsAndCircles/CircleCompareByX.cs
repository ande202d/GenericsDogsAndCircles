using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDogsAndCircles
{
    public class CircleCompareByX:IComparer<Circle>
    {
        public int Compare(Circle x, Circle y)
        {
            return x.X > y.X ? (int)x.X : (int)y.X;
        }
    }
}
