using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha um tipo de pizza: (C - Calabresa, P - Portuguesa");
            var tipoPizza = Console.ReadLine().ToUpper();

            var pizza = Loja1Factory.CriarPizza(tipoPizza);
            
            pizza.Preparar();
            pizza.Assar();
            pizza.Fatiar();
            pizza.Embalar();
            pizza.ProntaParaEntrega();
        }
    }
}
