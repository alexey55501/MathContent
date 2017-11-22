using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMathHelper
{
    public class MyMath : IMyMath
    {
        public int Factorial(int number)
        {
            if (number == 0)
                return 1;
            else if (number < 0)
                throw new ParameterException();
            else
            {
                int result = 1;

                for (int i = 1; i <= number; i++)
                {
                    result = result * i;
                }
                return result;
            }
        }

        public List<int> QuadraticEquation(int a, int b, int c)
        {
            List<int> results = new List<int>();

            var D = System.Math.Pow(b, 2) - 4 * a * c;
            if (D > 0 || D == 0)
            {
                var x1 = (-b + System.Math.Sqrt(D)) / (2 * a);
                var x2 = (-b - System.Math.Sqrt(D)) / (2 * a);

                if (D == 0)
                {
                    results.Add((int)x1);
                }
                else
                {
                    results.Add((int)x1);
                    results.Add((int)x2);
                }

            }
            else
            {
                results = null;
            }

            return results;
        }
    }

    [Serializable]
    internal class ParameterException : Exception
    {
        public ParameterException()
        {
        }

        public ParameterException(string message) : base(message)
        {
        }

        public ParameterException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ParameterException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
