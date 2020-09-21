using System.Collections.Generic;

namespace _33_2
{
    public class Tree
    {
        /// <summary>
        /// 剑指 Offer 32 - II. 从上到下打印二叉树 II
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            // 思路：使用队列
            var list = new List<IList<int>>();
            if (root == null)
            {
                return list;
            }
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var size = queue.Count;
                var level = new List<int>();
                for (int i = 0; i < size; i++)
                {
                    var outQueue = queue.Dequeue();
                    level.Add(outQueue.val);
                    if (outQueue.left != null)
                    {
                        queue.Enqueue(outQueue.left);
                    }

                    if (outQueue.right != null)
                    {
                        queue.Enqueue(outQueue.right);
                    }

                }
                list.Add(level);
            }

            return list;
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