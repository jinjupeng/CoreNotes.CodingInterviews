using System;

namespace _67
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pro = new Program();
            var data = pro.StrToInt("2147483648");
            Console.WriteLine(data);
        }

        /// <summary>
        /// 剑指 Offer 67. 把字符串转换成整数
        /// </summary>
        /// <param name="str">例如"123456"转为12345</param>
        /// <returns></returns>
        public int StrToInt(string str)
        {
            bool minus = false;
            int index = 0;
            long num = 0; // 不能直接声明int，声明为long是防止越界
            str = str.TrimStart(); // 去除开头空格
            if (string.IsNullOrWhiteSpace(str))
            {
                return 0;
            }

            var strArr = str.ToCharArray();
            // 负号
            if (strArr[0] == '-')
            {
                index++;
                minus = true;
            }
            // 加号
            if(strArr[0] == '+')
            {
                index++;
            }
            for (int i = index; i < strArr.Length; i++)
            {
                if(strArr[i] >= '0' && strArr[i] <= '9')
                {
                    int flag = minus ? -1 : 1;
                    num = num * 10 + flag * (strArr[i] - '0'); // num不能直接设置为int类型；如果为int类型时，当这一步num值大于int最大值或者小于int最小值时，会默认赋值int导致计算结果不正确

                    if(!minus && num > int.MaxValue)
                    {
                        num = int.MaxValue;
                        break;
                    }
                    if (minus && num < int.MinValue)
                    {
                        num = int.MinValue;
                        break;
                    }
                }
                else
                {
                    break;
                }
            }

            return (int)num;
        }
    }
}
