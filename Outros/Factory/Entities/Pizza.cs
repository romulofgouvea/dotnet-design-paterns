using System;
using System.Collections;

namespace Factory
{
    public abstract class Pizza
    {
        protected string Nome { get; set; }
        protected ArrayList Ingredientes = new ArrayList();

        public void Preparar()
        {
            Console.WriteLine("Preparando");
        }

        public void IrParaOForno()
        {
            Console.WriteLine("Indo para o forno");
        }

        public void Fatiar()
        {
            Console.WriteLine("Fatiando");
        }

        public void Embalar()
        {
            Console.WriteLine("Embalando");
        }

        public void ProntaParaEntrega()
        {
            Console.WriteLine("Pronta para entrega.");
        }
    }
}