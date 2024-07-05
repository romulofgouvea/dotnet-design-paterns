using System;

namespace ImplementacaoLazyEagerLoading
{
    //Carga Adiada - Adiando até quando for necessário, usada quando o custo é muito alto.
    public class SingletonLazy
    {
        private static int numeroInstancias = 0;

        private static readonly Lazy<SingletonLazy> InstanceLock = new(() => new SingletonLazy());

        private SingletonLazy()
        {
            numeroInstancias++;
            Console.WriteLine($"(SingletonLazy) Criando instancia estática {numeroInstancias}");
        }

        public static SingletonLazy Instance
        {
            get
            {
                return InstanceLock.Value;
            }
        }
    }
}