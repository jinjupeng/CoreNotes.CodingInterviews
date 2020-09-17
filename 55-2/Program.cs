using System;

namespace _55_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree();
            var treeNode = new TreeNode(3)
            {
                left = new TreeNode(9),
                right = new TreeNode(20) { left = new TreeNode(15), right = new TreeNode(7) }
            };
            var data = tree.IsBalanced(treeNode);
        }
    }
}
