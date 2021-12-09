using System;

namespace MathCalculate
{
    public static  class Calculate
    {
        public static int Max(int a, int b)
        {
            if (a>b)
            {
                return a;
            }
            return b;
        }
        public static int Min(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            return b;
        }
        /// <summary>
        /// Наибольший общий делитель
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int NOD(int a, int b)
        {
            int min = Min(a, b);
            int max = Max(a,b);
            int remind = max % min;
            if (remind == 0)
            {
                return min;
            }
           return NOD(max, remind);
        }

        /// <summary>
        /// Наименьшее общее кратное
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int NOK(int a, int b)
        {
            return a * b / NOD(a, b);
        }
    }
}
