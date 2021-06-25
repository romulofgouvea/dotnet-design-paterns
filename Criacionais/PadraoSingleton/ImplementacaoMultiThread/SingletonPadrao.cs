using System;

namespace ImplementacaoMultiThread
{
    public class SingletonPadrao
    {
        //Verificar as instancias geradas.
        private int numeroInstancias = 0;

        private static SingletonPadrao instance = null;

        //Definido privado para não ser instanciado
        private SingletonPadrao()
        {
            numeroInstancias++;
            Console.WriteLine($"(SingletonPadrao) Instâncias: {numeroInstancias.ToString()}");
        }

        public static SingletonPadrao Instance
        {
            get
            {
                if (instance is null)
                {
                    Console.WriteLine("Criando a instância");
                    instance = new SingletonPadrao();
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