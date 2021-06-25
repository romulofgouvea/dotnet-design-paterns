using System;

namespace ImplementacaoMultiThread
{
    public class SingletonMultiThreadOneroso
    {
        //Verificar as instancias geradas.
        private int numeroInstancias = 0;

        private static readonly object lockObject = new object();
        private static SingletonMultiThreadOneroso instance = null;

        private SingletonMultiThreadOneroso()
        {
            numeroInstancias++;
            Console.WriteLine($"(SingletonMultiThreadOneroso) Instâncias: {numeroInstancias.ToString()}");
        }

        public static SingletonMultiThreadOneroso Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance is null)
                    {
                        Console.WriteLine("Criando a instância");
                        instance = new SingletonMultiThreadOneroso();
                    }
                    else
                    {
                        Console.WriteLine("Retornando a instância");
                    }

                    return instance;
                }
            }
        }

    }
}