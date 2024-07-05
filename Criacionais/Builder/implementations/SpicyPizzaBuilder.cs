using Builder.entities;
using Builder.interfaces;

namespace Builder.implementations;

public class SpicyPizzaBuilder : IPizzaBuilder
{
    private Pizza _pizza = new Pizza();

    public void BuildDough()
    {
        _pizza.Dough = "macia";
    }

    public void BuildSauce()
    {
        _pizza.Sauce = "picante";
    }

    public void BuildTopping()
    {
        _pizza.Topping = "calabresa e queijo";
    }

    public Pizza GetPizza()
    {
        return _pizza;
    }
}