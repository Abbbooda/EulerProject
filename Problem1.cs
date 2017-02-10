using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject
{
    class Problem1
    {
        public int Mult3and5(int number, int max)
        {
            int result = 0;
            result = number * (max * (max + 1)) / 2;
            return result;
        }
    }
}
