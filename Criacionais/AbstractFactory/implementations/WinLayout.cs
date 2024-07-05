using AbstractFactory.interfaces;
using AbstractFactory.implementations;

namespace AbstractFactory.implementations;

public class WinLayout : IGUILayout
{
    public IButton CreateButton()
    {
        return new WinButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new WinCheckbox();
    }
}