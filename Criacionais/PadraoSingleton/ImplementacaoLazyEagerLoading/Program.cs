using System;
using System.Threading.Tasks;

namespace ImplementacaoLazyEagerLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Singleton Eager Loading");
            //Parallel.Invoke
            //(
            //    () => Thread1Eager(),
            //    () => Thread2Eager()
            //);

            Console.WriteLine("Singleton Lazy Loading");
            Parallel.Invoke
            (
                () => Thread1Lazy(),
                () => Thread2Lazy()
            );
        }

        private static void Thread1Eager()
        {
            SingletonEager s1 = SingletonEager.Instance;
            Console.WriteLine("Thread1 - Eager");
        }

        private static void Thread2Eager()
        {
            SingletonEager s2 = SingletonEager.Instance;
            Console.WriteLine("Thread2 -Eager");
        }

        private static void Thread1Lazy()
        {
            SingletonLazy s1 = SingletonLazy.Instance;
            Console.WriteLine("Thread1 - Lazy");
        }

        private static void Thread2Lazy()
        {
            SingletonLazy s2 = SingletonLazy.Instance;
            Console.WriteLine("Thread2 - Lazy");
        }
    }
}
