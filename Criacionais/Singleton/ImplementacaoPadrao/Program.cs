using System;

namespace ImplementacaoPadrao
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Implementação Default
            Console.WriteLine("Instancia de s1:");
            var s1 = Singleton.Instance;

            Console.WriteLine("\nInstancia de s2:");
            var s2 = Singleton.Instance;

            Console.WriteLine($"\ns1 == s2 : {s1 == s2}");
            #endregion
        }
    }
}
