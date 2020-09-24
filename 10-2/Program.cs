using System;
using System.Collections.Generic;

namespace _10_2
{
    class Program
    {
        private readonly Dictionary<int, int> _dict = new Dictionary<int, int>();
        static void Main(string[] args)
        {
            var pro = new Program();
            var data = pro.NumWays(100);
            Console.WriteLine("Hello World!");
        }

        /*
        /// <summary>
        /// 剑指 Offer 10- II. 青蛙跳台阶问题
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int NumWays(int n)
        {
            // 递归（超出时间限制）
            if (n <= 1) return 1;
            var bigInt = NumWays(n - 1) + NumWays(n - 2);

            return bigInt % 1000000007;
        }
        */

        /// <summary>
        /// 剑指 Offer 10- II. 青蛙跳台阶问题
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int NumWays(int n)
        {
            // 递归 + 备忘录去重
            if (n <= 1) return 1;
            // 先判断有没有计算过
            if (_dict.ContainsKey(n))
            {
                // 计算过，直接返回
                return _dict[n];
            }

            // 没有计算过，递归计算，并且把结果保存到字典中
            _dict.Add(n, (NumWays(n - 1) + NumWays(n - 2)) % 1000000007);
            return _dict[n];
        }
    }
}
