using System;

namespace ImplementacaoEstatico
{
    //É obrigatorio a utilização do sealed para que nenhuma classe herde esta e nao quebre o principio do pattern
    public sealed class Singleton
    {
        private static int numeroInstancias = 0;
        private static readonly Singleton instance;

        private Singleton() { }

        //Com o construtor estático ele carrega junto a aplicação e gerará apenas uma instancia
        static Singleton()
        {
            numeroInstancias++;
            Console.WriteLine($"(Singleton) Criando instancia estática {numeroInstancias}");
            instance = new Singleton();
        }

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }

    }
}