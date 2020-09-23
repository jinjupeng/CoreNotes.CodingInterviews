using System;
using System.Collections.Generic;

namespace _31
{
    class Program
    {
        static void Main(string[] args)
        {
            var pro = new Program();
            var pushed = new int[] { 1, 2, 3, 4, 5 };
            var poped = new int[] { 4, 3, 5, 1, 2 };
            var data = pro.ValidateStackSequences(pushed, poped);
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 剑指 Offer 31. 栈的压入、弹出序列
        /// </summary>
        /// <param name="pushed"></param>
        /// <param name="popped"></param>
        /// <returns></returns>
        public bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            // 思路：将数组pushed按顺序入栈，在入栈过程中，判断栈顶元素是否和数组poped中下标指向的元素相等，
            // 如果相等，则出栈，之后继续入栈且数组poped索引下标向后移一位
            int popIndex = 0;
            var stack = new Stack<int>();
            foreach (var item in pushed)
            {
                stack.Push(item);
                while (stack.Count > 0 && stack.Peek() == popped[popIndex] && popIndex < popped.Length)
                {
                    stack.Pop();
                    popIndex++;
                }
            }

            return popIndex == popped.Length;
        }
    }
}
