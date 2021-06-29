using System;
using System.Collections;

namespace Factory
{
    public class Loja1Factory
    {
        public static Pizza CriarPizza(string tipoPizza)
        {
            Pizza pizza = null;
            switch (tipoPizza.ToUpper())
            {
                case "C":
                    pizza = new PizzaCalabresa();
                    break;
                case "P":
                    pizza = new PizzaPortuguesa();
                    break;
                default:
                    throw new ApplicationException("Não existe essa pizza em nosso cardápio.");
            }
            return pizza;
        }
    }
}