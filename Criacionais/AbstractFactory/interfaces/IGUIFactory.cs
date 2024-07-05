namespace AbstractFactory.interfaces;

public interface IGUILayout
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}