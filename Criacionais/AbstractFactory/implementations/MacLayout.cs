using AbstractFactory.interfaces;
using AbstractFactory.implementations;

namespace AbstractFactory.implementations;

public class MacLayout : IGUILayout
{
    public IButton CreateButton()
    {
        return new MacButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new MacCheckbox();
    }
}
