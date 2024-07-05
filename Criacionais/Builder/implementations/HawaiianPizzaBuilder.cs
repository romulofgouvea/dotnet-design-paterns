using Builder.entities;
using Builder.interfaces;

namespace Builder.implementations;

public class HawaiianPizzaBuilder : IPizzaBuilder
{
    private Pizza _pizza = new Pizza();

    public void BuildDough()
    {
        _pizza.Dough = "crocante";
    }

    public void BuildSauce()
    {
        _pizza.Sauce = "suave";
    }

    public void BuildTopping()
    {
        _pizza.Topping = "presunto e abacaxi";
    }

    public Pizza GetPizza()
    {
        return _pizza;
    }
}