using System;

namespace _30
{
    public class MinStack
    {
        private int[] _array;

        // 注意：最小值应该是栈中的值，而不是0
        public MinStack()
        {
            // 初始化为空栈
            this._array = new int[0];
            this.MinValue = default(int);
        }

        /// <summary>
        /// 入栈
        /// </summary>
        /// <param name="x"></param>
        public void Push(int x)
        {
            Array.Resize(ref _array, _array.Length + 1);
            _array[_array.Length - 1] = x;
            if (_array.Length == 1)
            {
                MinValue = _array[0];
            }
            else
            {
                if (x < MinValue)
                {
                    MinValue = x;
                }
            }
        }

        /// <summary>
        /// 出栈
        /// </summary>
        public void Pop()
        {
            // 出栈时，赋初值
            MinValue = _array[0];
            if (_array.Length >= 1)
            {
                var newArray = new int[_array.Length - 1];
                for (int i = 0; i < newArray.Length; i++)
                {
                    newArray[i] = _array[i];
                    if (newArray[i] < MinValue)
                    {
                        MinValue = newArray[i];
                    }
                }

                _array = newArray;
            }
        }

        /// <summary>
        /// 获取栈顶元素
        /// </summary>
        /// <returns></returns>
        public int Top()
        {
            // 栈为null返回默认值
            if (_array.Length == 0)
            {
                return default(int);
            }

            return _array[_array.Length - 1];

        }

        /// <summary>
        /// 检索栈中的最小元素
        /// </summary>
        /// <returns></returns>
        public int Min()
        {
            // 栈为null返回默认值
            if (_array.Length == 0)
            {
                MinValue = default(int);
            }
            return MinValue;
        }

        public int MinValue
        {
            get;
            private set;
        }
    }
}