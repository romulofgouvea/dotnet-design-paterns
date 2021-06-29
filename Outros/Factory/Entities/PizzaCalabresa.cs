using System;
using System.Collections;

namespace Factory
{
    public class PizzaCalabresa : Pizza
    {
        public PizzaCalabresa()
        {
            Nome = "Pizza Calabresa";
            Ingredientes.Add("Massa");
            Ingredientes.Add("Molho de tomate");
            Ingredientes.Add("Calabresa");
            Ingredientes.Add("Ovo picados");
        }
    }
}