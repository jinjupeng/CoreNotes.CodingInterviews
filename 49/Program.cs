using System;

namespace _49
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 剑指 Offer 49. 丑数
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int NthUglyNumber(int n)
        {
            if (n <= 0)
                return -1;
            var dp = new int[n];
            dp[0] = 1; // 基础丑数为1
            int id2 = 0, id3 = 0, id5 = 0;
            for (var i = 1; i < n; i++)
            {
                dp[i] = Math.Min(dp[id2] * 2, Math.Min(dp[id3] * 3, dp[id5] * 5));
                // 这里不用else if的原因是有可能id2(3) * 2 == id3(2) * 3
                // 这种情况两个指针都要后移
                if (dp[id2] * 2 == dp[i])
                    id2 += 1;
                if (dp[id3] * 3 == dp[i])
                    id3 += 1;
                if (dp[id5] * 5 == dp[i])
                    id5 += 1;
            }
            return dp[n - 1];
        }
    }
}
