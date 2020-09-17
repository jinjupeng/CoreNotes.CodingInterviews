namespace _55_2
{
    public class Tree
    {
        /// <summary>
        /// 剑指 Offer 55 - II. 平衡二叉树
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public bool IsBalanced(TreeNode root)
        {
            /*
             * 输入一棵二叉树的根节点，判断该树是不是平衡二叉树。如果某二叉树中任意节点的左右子树的深度相差不超过1，那么它就是一棵平衡二叉树。
             */
            if (root == null)
            {
                return true; // 空树是平衡二叉树
            }

            var left = MaxDepth(root.left);
            var right = MaxDepth(root.right);
            var diff = left - right;
            if (diff > 1 || diff < -1)
            {
                return false;
            }

            return IsBalanced(root.left) && IsBalanced(root.right);
        }

        /// <summary>
        /// 二叉树深度
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        private int MaxDepth(TreeNode root)
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