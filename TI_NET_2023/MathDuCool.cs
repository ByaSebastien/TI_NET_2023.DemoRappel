using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023
{
    public static class MathDuCool
    {
        public static int Addition(int a, int b)
        {
            return a + b;
        }
        public static float Addition(float a, int b)
        {
            return a + b;
        }
        public static float Addition(float a, float b)
        {
            return a + b;
        }
        public static float Addition(int a, float b)
        {
            return a + b;
        }

        public static int Division(int a, int b)
        {
            if(b == 0)
            {
                Console.WriteLine("Impossible");
                throw new DivideByZeroException();
            }
            return (a / b);
        }
    }
}
