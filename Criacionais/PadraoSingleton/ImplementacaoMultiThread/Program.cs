using System;
using System.Threading;
using System.Threading.Tasks;

namespace ImplementacaoMultiThread
{
    class Program
    {
        static void Main(string[] args)
        {
            //O singleton padrão cria varias instâncias quando está no cenário multithread
            //quebrando o principio do padrão
            Console.WriteLine("Singleton Padrão");
            Parallel.Invoke(
                () => Thread1SingletonPadrao(),
                () => Thread2SingletonPadrao()
            );

            // Console.WriteLine("\n\nSingleton MultiThread Oneroso");
            // Parallel.Invoke(
            //     () => Thread1SingletonMultiThreadOneroso(),
            //     () => Thread2SingletonMultiThreadOneroso()
            // );

            // Console.WriteLine("\n\nSingleton MultiThread");
            // Parallel.Invoke(
            //     () => Thread1SingletonMultiThread(),
            //     () => Thread2SingletonMultiThread()
            // );

            Console.Read();
        }

        #region Singleton Padrão
        private static void Thread1SingletonPadrao()
        {
            SingletonPadrao s1 = SingletonPadrao.Instance;
            Console.WriteLine("Thread1");
        }

        private static void Thread2SingletonPadrao()
        {
            SingletonPadrao s2 = SingletonPadrao.Instance;
            Console.WriteLine("Thread2");
        }
        #endregion

        #region Singleton MultiThread Oneroso
        private static void Thread1SingletonMultiThreadOneroso()
        {
            SingletonMultiThreadOneroso s1 = SingletonMultiThreadOneroso.Instance;
            Console.WriteLine("Thread1 - SingletonMultiThreadOneroso");
        }

        private static void Thread2SingletonMultiThreadOneroso()
        {
            SingletonMultiThreadOneroso s2 = SingletonMultiThreadOneroso.Instance;
            Console.WriteLine("Thread2 - SingletonMultiThreadOneroso");
        }
        #endregion

        #region Singleton MultiThread
        private static void Thread1SingletonMultiThread()
        {
            SingletonMultiThread s1 = SingletonMultiThread.Instance;
            Console.WriteLine("Thread1 - SingletonMultiThread");
        }

        private static void Thread2SingletonMultiThread()
        {
            SingletonMultiThread s2 = SingletonMultiThread.Instance;
            Console.WriteLine("Thread2 - SingletonMultiThread");
        }
        #endregion
    }
}