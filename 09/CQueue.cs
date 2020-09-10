using System.Collections.Generic;

namespace _09
{
    /// <summary>
    /// 剑指 Offer 09. 用两个栈实现队列
    /// </summary>
    public class CQueue
    {
        private readonly Stack<int> _firstStack = new Stack<int>();
        private readonly Stack<int> _secondStack = new Stack<int>();
        public CQueue()
        {

        }

        /// <summary>
        /// 入队
        /// </summary>
        /// <param name="value"></param>
        public void AppendTail(int value)
        {
            _firstStack.Push(value);
        }

        /// <summary>
        /// 出队
        /// </summary>
        /// <returns></returns>
        public int DeleteHead()
        {
            if (_firstStack.Count == 0)
            {
                return -1;
            }
            foreach (var i in _firstStack)
            {
                _secondStack.Push(i);
            }
            _firstStack.Clear();

            var headItem = _secondStack.Pop();
            
            foreach (var i in _secondStack)
            {
                _firstStack.Push(i);
            }
            _secondStack.Clear();
            return headItem;
        }
    }
}