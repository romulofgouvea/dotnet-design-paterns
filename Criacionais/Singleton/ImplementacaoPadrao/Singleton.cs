using System;

namespace ImplementacaoPadrao
{
    public class Singleton
    {
        //Verificar as instancias geradas.
        private int numeroInstancias = 0;

        private static Singleton instance;

        //Definido privado para não ser instanciado
        private Singleton()
        {
            numeroInstancias++;
            Console.WriteLine($"(PadraoSingleton) Instâncias: {numeroInstancias.ToString()}");
        }

        public static Singleton Instance
        {
            get
            {
                if (instance is null)
                {
                    Console.WriteLine("Criando a instância");
                    instance = new Singleton();
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