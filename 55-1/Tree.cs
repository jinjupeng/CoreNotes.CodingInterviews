namespace _55_1
{
    public class Tree
    {
        /// <summary>
        /// 剑指 Offer 55 - I. 二叉树的深度
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            // 思路：深度优先遍历搜索(就是递归)
            var leftDepth = MaxDepth(root.left);
            var rightDepth = MaxDepth(root.right);

            if (leftDepth > rightDepth)
            {
                return leftDepth + 1;
            }

            return rightDepth + 1;
        }
    }

    /// <summary>
    /// 树节点
    /// </summary>
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}