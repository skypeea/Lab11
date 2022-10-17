using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    struct LinearEquation
    {
        double k;
        double b;
        public LinearEquation(double k, double b)
        {
            this.k = k;
            this.b = b;
        }
        public double Solve()
        {
            return - b/k;
        }
    }
}
