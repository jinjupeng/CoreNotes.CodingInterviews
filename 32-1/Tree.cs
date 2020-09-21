using System;
using System.Collections;
using System.Collections.Generic;

namespace _32_1
{
    public class Tree
    {
        /// <summary>
        /// 剑指 Offer 32 - I. 从上到下打印二叉树
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int[] LevelOrder(TreeNode root)
        {
            if (root == null)
            {
                return new int[]{};
            }
            var list = new List<int>();
            Queue<TreeNode> queueNodes = new Queue<TreeNode>();
            queueNodes.Enqueue(root);
            // 利用队列先进先出的特性存储节点并输出
            while (queueNodes.Count > 0)
            {
                var tempNode = queueNodes.Dequeue();
                list.Add(tempNode.val);
                if (tempNode.left != null)
                {
                    queueNodes.Enqueue(tempNode.left);
                }

                if (tempNode.right != null)
                {
                    queueNodes.Enqueue(tempNode.right);
                }
            }

            return list.ToArray();
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}