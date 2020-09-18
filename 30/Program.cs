using System;

namespace _30
{
    class Program
    {
        static void Main(string[] args)
        {
            MinStack minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            var a = minStack.Min(); // 返回 - 3.
            minStack.Pop();
            var b = minStack.Top(); // 返回 0.
            var c = minStack.Min(); // 返回 - 2.

            Console.WriteLine("Hello World!");
        }
    }
}
