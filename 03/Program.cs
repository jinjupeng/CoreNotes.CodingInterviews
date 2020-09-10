using System;
using System.Collections.Generic;
using System.Linq;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 剑指 Offer 03. 数组中重复的数字
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindRepeatNumber(int[] nums)
        {
            var dict = new Dictionary<int, int>(10);
            foreach (var num in nums)
            {
                if (dict.ContainsKey(num))
                {
                    var value = dict[num] + 1;
                    dict[num] = value;
                    if (value > 1)
                    {
                        return num;
                    }
                }
                else
                {
                    dict.Add(num, 1);
                }
            }

            return -1;
        }
    }
}
