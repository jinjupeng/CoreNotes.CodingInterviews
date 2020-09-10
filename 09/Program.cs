using System;

namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {
            var cQueue = new CQueue();
            cQueue.AppendTail(3);
            var a = cQueue.DeleteHead();
            var b = cQueue.DeleteHead();
            Console.WriteLine("Hello World!");
        }
    }

}
