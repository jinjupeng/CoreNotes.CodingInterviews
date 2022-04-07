// 面试题3（一）：找出数组中重复的数字
// 题目：在一个长度为n的数组里的所有数字都在0到n-1的范围内。数组中某些数字是重复的，但不知道有几个数字重复了，
// 也不知道每个数字重复了几次。请找出数组中任意一个重复的数字。例如，如果输入长度为7的数组{2, 3, 1, 0, 2, 5, 3}，
// 那么对应的输出是重复的数字2或者3。

using System;
using System.Collections.Generic;

namespace _03_01_DuplicationArray
{
    class FindDuplication
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
