using System;
using System.Collections.Generic;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new ListNode(1) {next = new ListNode(3) {next = new ListNode(2)}};
            var pro = new Program();
            var data = pro.ReversePrint(head);
        }

        /// <summary>
        /// 剑指 Offer 06. 从尾到头打印链表
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public int[] ReversePrint(ListNode head)
        {
            if (head == null)
            {
                return new int[]{};
            }
            // 思路：使用栈
            var nodeStack = new Stack<int>();
            // 入栈
            while (head != null)
            {
                nodeStack.Push(head.val);
                head = head.next;
            }

            var array = new int[nodeStack.Count];
            for (int i = 0; i < array.Length; i++)
            {
                // 出栈
                array[i] = nodeStack.Pop();
            }

            return array;
        }
    }
}
