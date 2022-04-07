// 面试题3（二）：不修改数组找出重复的数字
// 题目：在一个长度为n+1的数组里的所有数字都在1到n的范围内，所以数组中至
// 少有一个数字是重复的。请找出数组中任意一个重复的数字，但不能修改输入的
// 数组。例如，如果输入长度为8的数组{2, 3, 5, 4, 3, 2, 6, 7}，那么对应的
// 输出是重复的数字2或者3。

using System;

namespace _03_02_DuplicationArrayNoEdit
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 2, 3, 5, 4, 3, 2, 6, 7 };
            var getDuplication = new Program().GetDuplication(array);
            Console.WriteLine($"重复值为：{getDuplication}");
        }

        /// <summary>
        /// 数组元素的取值范围是 [1, n]，对该范围对半划分，分成 [1, middle], [middle+1, n]。
        /// 计算数组中有多少个(count)元素落在 [1, middle] 区间内，如果 count 大于 middle-1+1，那么说明这个范围内有重复元素，否则在另一个范围内。
        /// 继续对这个范围对半划分，继续统计区间内元素数量。
        /// 时间复杂度 O(n* log n)，空间复杂度 O(1)。
        /// 注意，此方法无法找出所有重复的元素。
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public int GetDuplication(int[] numbers)
        {
            if (numbers == null || numbers.Length < 1)
            {
                return -1;
            }

            int start = 1;
            int end = numbers.Length - 1;
            while (end >= start)
            {
                int middle = start + ((end - start) >> 1);

                // 调用 log n 次
                int count = CountRange(numbers, start, middle);
                if (start == end)
                {
                    if (count > 1)
                    {
                        return start;
                    }
                    break;
                }
                else
                {
                    // 无法找出所有重复的数
                    if (count > (middle - start) + 1)
                    {
                        end = middle;
                    }
                    else
                    {
                        start = middle + 1;
                    }
                }
            }
            return -1;
        }

        private int CountRange(int[] numbers, int start, int end)
        {
            if (numbers == null)
            {
                return 0;
            }
            int count = 0;
            foreach (int e in numbers)
            {
                if (e >= start && e <= end)
                {
                    ++count;
                }
            }
            return count;
        }
    }
}
