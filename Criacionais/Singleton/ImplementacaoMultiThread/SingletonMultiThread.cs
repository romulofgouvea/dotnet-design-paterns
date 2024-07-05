using System;

namespace ImplementacaoMultiThread
{
    public class SingletonMultiThread
    {
        //Verificar as instancias geradas.
        private int numeroInstancias = 0;

        private static readonly object lockObject = new object();
        private static SingletonMultiThread instance = null;

        //Definido privado para não ser instanciado
        private SingletonMultiThread()
        {
            numeroInstancias++;
            Console.WriteLine($"(SingletonMultiThread) Instâncias: {numeroInstancias.ToString()}");
        }

        public static SingletonMultiThread Instance
        {
            get
            {
                // Com a verificação antes do lock o bloqueio é realizado apenas 1 vez
                if (instance is null)
                {
                    lock (lockObject)
                    {
                        if (instance is null)
                        {
                            Console.WriteLine("Criando a instância");
                            instance = new SingletonMultiThread();
                        }
                        else
                        {
                            Console.WriteLine("Retornando a instância");
                        }
                    }
                }
                return instance;
            }
        }

    }
}