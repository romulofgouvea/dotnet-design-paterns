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
            Console.WriteLine($"Preparando a {Nome}");
        }

        public void Assar()
        {
            Console.WriteLine("Assando");
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
            Console.WriteLine($"A {Nome} ficou pronta para entrega.");
        }
    }
}