using System;

namespace _64
{
    class Program
    {
        static void Main(string[] args)
        {
            var pro = new Program();
            var data = pro.SumNums(9);
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 剑指 Offer 64. 求1+2+…+n
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int SumNums(int n)
        {
            // 思路：递归
            if (n == 1)
            {
                return 1;
            }
            return n + SumNums(n - 1);
        }
    }
}
