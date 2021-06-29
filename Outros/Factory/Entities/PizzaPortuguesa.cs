using System;
using System.Collections;

namespace Factory
{
    public class PizzaPortuguesa : Pizza
    {
        public PizzaPortuguesa()
        {
            Nome = "Pizza Portuguesa";
            Ingredientes.Add("Massa");
            Ingredientes.Add("Molho de tomate");
            Ingredientes.Add("Palmito");
            Ingredientes.Add("Azeitona");
        }
    }
}