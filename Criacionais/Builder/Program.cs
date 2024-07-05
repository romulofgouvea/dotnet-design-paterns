using Builder.entities;
using Builder.implementations;
using Builder.interfaces;

namespace Builder;

static class Program
{
    static void Main(string[] args)
    {
        Waiter waiter = new Waiter();
        IPizzaBuilder hawaiianPizzaBuilder = new HawaiianPizzaBuilder();
        IPizzaBuilder spicyPizzaBuilder = new SpicyPizzaBuilder();

        waiter.SetPizzaBuilder(hawaiianPizzaBuilder);
        waiter.MakePizza();
        Pizza pizza = waiter.GetPizza();
        pizza.Display();

        waiter.SetPizzaBuilder(spicyPizzaBuilder);
        waiter.MakePizza();
        pizza = waiter.GetPizza();
        pizza.Display();
    }
}