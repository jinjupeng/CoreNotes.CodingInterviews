// 面试题2：实现Singleton模式
// 题目：设计一个类，我们只能生成该类地一个实例

using System;

namespace _02_Singleton
{
    /// <summary>
    /// 不好的解法一：只适用于单线程环境
    /// </summary>
    public sealed class Singleton1
    {
        /// <summary>
        /// 构造函数设为私有函数以禁止他人创建实例
        /// </summary>
        private Singleton1()
        {

        }

        private static Singleton1 instance = null;
        public static Singleton1 Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Singleton1();
                }

                return instance;
            }
        }
    }

    /// <summary>
    /// 不好地解法二：虽然在多线程环境中能工作，但是效率不高
    /// </summary>
    public sealed class Singleton2
    {
        private Singleton2()
        {

        }

        private static readonly object syncObj = new object();

        private static Singleton2 instance = null;
        public static Singleton2 Instance
        {
            get
            {
                // 加锁比较耗时
                lock (syncObj)
                {
                    if(instance == null)
                    {
                        instance = new Singleton2();
                    }

                    return instance;
                }
            }
        }
    }

    /// <summary>
    /// 可行地解法：加同步锁前后两次判断实例是否已存在
    /// 在实例还没有创建之前需要加锁操作，以保证只有一个线程创建出实例。
    /// 而当实例已经创建之后，已经不需要在执行加锁操作了。
    /// </summary>
    public sealed class Singleton3
    {
        private Singleton3()
        {
        }

        private static object syncObj = new object();

        private static Singleton3 instance = null;
        public static Singleton3 Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncObj)
                    {
                        if (instance == null)
                            instance = new Singleton3();
                    }
                }

                return instance;
            }
        }
    }

    /// <summary>
    /// 强烈推荐的解法一：利用静态构造函数
    /// C#语法中有一个函数能够确保只调用一次，那就是静态构造函数，可以利用这个特性实现单例模式。
    /// </summary>
    public sealed class Singleton4
    {
        private Singleton4()
        {
            Console.WriteLine("An instance of Singleton4 is created.");
        }

        public static void Print()
        {
            Console.WriteLine("Singleton4 Print");
        }

        private static Singleton4 instance = new Singleton4();
        public static Singleton4 Instance
        {
            get
            {
                return instance;
            }
        }
    }

    /// <summary>
    /// 强烈推荐的解法二：实现按需创建实例
    /// </summary>
    public sealed class Singleton5
    {
        Singleton5()
        {
            Console.WriteLine("An instance of Singleton5 is created.");
        }

        public static void Print()
        {
            Console.WriteLine("Singleton5 Print");
        }

        public static Singleton5 Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        class Nested
        {
            static Nested()
            {
            }

            internal static readonly Singleton5 instance = new Singleton5();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 也会打印An instance of Singleton4 is created.
            Singleton4.Print();

            // 不会打印An instance of Singleton5 is created.
            Singleton5.Print();
        }
    }
}
