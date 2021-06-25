using System;

namespace ImplementacaoLazyEagerLoading
{
    public class SingletonEager
    {
        private static int numeroInstancias = 0;

        //Carga Antecipada - Vantagem é a CLR cuidando da inicialização e da segurança no multi thread
        private static readonly SingletonEager instance = new();

        private SingletonEager()
        {
            numeroInstancias++;
            Console.WriteLine($"(SingletonEager) Criando instancia estática {numeroInstancias}");
        }

        public static SingletonEager Instance
        {
            get
            {
                return instance;
            }
        }
    }
}