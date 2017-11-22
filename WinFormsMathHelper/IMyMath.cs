using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMathHelper
{
    interface IMyMath
    {
        int Factorial(int number);
        List<int> QuadraticEquation(int a, int b, int c);
    }
}
