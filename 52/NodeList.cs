using System.Collections.Generic;

namespace _52
{
    public class NodeList
    {
        /// <summary>
        /// 剑指 Offer 52. 两个链表的第一个公共节点
        /// </summary>
        /// <param name="headA"></param>
        /// <param name="headB"></param>
        /// <returns></returns>
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            // 思路：利用栈后进先出的特点，从链表尾依次向前比较
            if (headA == null || headB == null)
            {
                return null;
            }
            var stackA = new Stack<ListNode>();
            var stackB = new Stack<ListNode>();
            while (headA != null)
            {
                stackA.Push(headA);
                headA = headA.next;
            }

            while (headB != null)
            {
                stackB.Push(headB);
                headB = headB.next;
            }

            ListNode result = null;
            while (stackA.Count > 0 && stackB.Count > 0)
            {
                var nodeA = stackA.Peek();
                var nodeB = stackB.Peek();

                if (nodeA == nodeB)
                {
                    result = nodeA;
                    stackA.Pop();
                    stackB.Pop();
                }
                else
                {
                    break;
                }
            }

            return result;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}