using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            var pro = new Program();
            /*
            int[][] matrix = new int[][]
            {
                new int[] { 1, 4, 7, 11, 15 }, new int[] { 2, 5, 8, 12, 19 }, new int[] { 3, 6, 9, 16, 22 }, new int[] { 10, 13, 14, 17, 24 }, new int[] {18, 21, 23, 26, 30 }
            };
            */
            // int[][] matrix = new int[][] { new int[] { -5 },  };
            int[][] matrix = new int[][] { new int[] { -1, 3 }, };
            // int[][] matrix = new int[][] { new int[] {  }, };
            // int[][] matrix = new int[][] { new int[] { }, new int[] { } };
            // int[][] matrix = new int[][] { new int[] { }, new int[] { 1 } };
            // int[][] matrix = new int[][] { new int[] { 1 }, new int[] { } };
            // int[][] matrix = new int[][] { };
            // int[][] matrix = new int[][] { new int[] { 1 }, };
            var result = pro.FindNumberIn2DArray(matrix, 3);
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 剑指 Offer 04. 二维数组中的查找
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool FindNumberIn2DArray(int[][] matrix, int target)
        {
            // 思路1：暴力算法
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == target)
                        return true;
                }
            }
            return false;

            // 思路2：从二维数组的右上角看，可视为一个二叉搜索树（BST）
        }
    }
}
