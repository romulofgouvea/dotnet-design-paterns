using System;
using System.Threading.Tasks;

namespace ImplementacaoEstatico
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke
            (
                () => Thread1(),
                () => Thread2()
            );


            Singleton s3 = Singleton.Instance;
        }

        private static void Thread1()
        {
            Singleton s1 = Singleton.Instance;
            Console.WriteLine("Thread1");
        }

        private static void Thread2()
        {
            Singleton s2 = Singleton.Instance;
            Console.WriteLine("Thread2");
        }
    }
}
