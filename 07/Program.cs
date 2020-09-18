using System;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree();
            var preOrder = new int[] { 3, 9, 20, 15, 7 };
            var inOrder = new int[] { 9, 3, 15, 20, 7 };
            var postOrder = new int[] { 9, 15, 7, 20, 3 };
            // var data = tree.BuildTree(preOrder, inOrder); // 前序、中序构造二叉树
            var data2 = tree.BuildTree2(inOrder, postOrder); // 中序、后序构造二叉树
            Console.WriteLine("Hello World!");
        }
    }
}
