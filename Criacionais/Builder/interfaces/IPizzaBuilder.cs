using Builder.entities;

namespace Builder.interfaces;

public interface IPizzaBuilder
{
    void BuildDough();
    void BuildSauce();
    void BuildTopping();
    Pizza GetPizza();
}