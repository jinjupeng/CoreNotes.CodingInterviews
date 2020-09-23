namespace _27
{
    public class Tree
    {
        /// <summary>
        /// 剑指 Offer 27. 二叉树的镜像
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public TreeNode MirrorTree(TreeNode root)
        {
            // 思路：采用前序遍历
            if (root == null)
            {
                return null;
            }

            // 保存右子树
            var rightTree = root.right;
            // 交换左右子树的位置
            root.right = MirrorTree(root.left);
            root.left = MirrorTree(rightTree);
            return root;
        }

        public TreeNode MirrorTree2(TreeNode root)
        {
            // 思路：采用中序遍历，左、根、右
            if (root == null)
            {
                return null;
            }
            MirrorTree2(root.left); // 递归找到左节点
            var rightNode = root.right; // 保存右节点
            root.right = root.left;
            root.left = rightNode;
            // 递归找到右节点 继续交换 : 因为此时左右节点已经交换了,所以此时的右节点为root.left
            MirrorTree2(root.left);

            return root;
        }

        public TreeNode MirrorTree3(TreeNode root)
        {
            // 思路：采用后序遍历，从下向上交换
            if (root == null)
            {
                return null;
            }
            var leftNode = MirrorTree3(root.left);
            var rightNode = MirrorTree3(root.right);
            root.right = leftNode;
            root.left = rightNode;
            return root;
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