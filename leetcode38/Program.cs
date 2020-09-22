using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 剑指 Offer 38. 字符串的排列
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string[] Permutation(string s)
        {
            // 思路：回溯算法
            var arr = s.ToCharArray();
            var strArr = new string[arr.Length];
            for (var i = 0; i < arr.Length; i++)
            {
                strArr[i] = arr[i].ToString();
            }
            // HashSet用于去重
            HashSet<string> hashSet = new HashSet<string>();
            Permute(strArr, 0, hashSet);
            return hashSet.ToArray();
        }

        public void Permute(string[] array, int begin, HashSet<string> result)
        {
            // 遍历完了一个全排列结果
            if (begin == array.Length)
            {
                var str = string.Join("", array);
                if (!result.Contains(str))
                {
                    result.Add(str);
                }
            }
            else
            {
                Permute(array, begin + 1, result);
                int i;
                for (i = begin + 1; i < array.Length; i++)
                {
                    // 交换数组下标位置
                    var t = array[begin];
                    array[begin] = array[i];
                    array[i] = t;
                    Permute(array, begin + 1, result);
                    // 交换数组下标位置
                    t = array[begin];
                    array[begin] = array[i];
                    array[i] = t;
                }
            }
        }
    }
}
