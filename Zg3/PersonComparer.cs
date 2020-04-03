using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zg3
{
    class PersonComparer :IComparer
    {
        public int Compare(Object x, Object y)
        {
           Person xp = (Person)x;
           Person yp = (Person)y;
            if (xp.Age == yp.Age) return 0;
                else if (xp.Age > yp.Age) return 1;
                else return -1;
        }
    }
}
