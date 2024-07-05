using Builder.entities;
using Builder.interfaces;

namespace Builder.entities;

public class Waiter
{
    private IPizzaBuilder _pizzaBuilder;

    public void SetPizzaBuilder(IPizzaBuilder pb)
    {
        _pizzaBuilder = pb;
    }

    public Pizza GetPizza()
    {
        return _pizzaBuilder.GetPizza();
    }

    public void MakePizza()
    {
        _pizzaBuilder.BuildDough();
        _pizzaBuilder.BuildSauce();
        _pizzaBuilder.BuildTopping();
    }
}