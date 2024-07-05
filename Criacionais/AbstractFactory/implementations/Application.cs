using AbstractFactory.interfaces;
using AbstractFactory.implementations;

namespace AbstractFactory.implementations;

public class Application
{
    private IGUILayout gui;
    private IButton button;
    private ICheckbox checkbox;

    public Application(IGUILayout gui)
    {
        this.gui = gui;
    }

    public void CreateUI()
    {
        button = gui.CreateButton();
        checkbox = gui.CreateCheckbox();
    }

    public void PaintUI()
    {
        button.Paint();
        checkbox.Paint();
    }
}
