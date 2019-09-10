using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDogsAndCircles
{
    public class DogCompareByHeight:IComparer<Dog>
    {
        public int Compare(Dog x, Dog y)
        {
            return x.Height > y.Height ? x.Height : y.Height;
        }
    }
}
