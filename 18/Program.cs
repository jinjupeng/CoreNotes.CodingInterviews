using System;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            var pro = new Program();
            var head = new ListNode(4) {next = new ListNode(5) {next = new ListNode(1) {next = new ListNode(9)}}};
            var data = pro.DeleteNode(head, 9);
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 剑指 Offer 18. 删除链表的节点
        /// 题目保证链表中节点的值互不相同
        /// </summary>
        /// <param name="head"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public ListNode DeleteNode(ListNode head, int val)
        {
            if (head != null)
            {
                // 删除头指针
                if (head.val == val)
                {
                    head = head.next;
                    return head;
                }

                var point = head;
                // 删除其他节点指针
                while (point != null)
                {
                    var curNode = point.next;
                    if (curNode.val == val)
                    {
                        point.next = curNode.next;
                        return head;
                    }
                    point = point.next;
                }
            }

            return head;
        }
    }
}
