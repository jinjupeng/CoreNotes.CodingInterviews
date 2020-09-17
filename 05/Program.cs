using System;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 剑指 Offer 05. 替换空格
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string ReplaceSpace(string s)
        {
            return s.Replace(" ", "%20");
        }
    }
}
