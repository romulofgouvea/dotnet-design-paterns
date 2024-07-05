using AbstractFactory.interfaces;

namespace AbstractFactory.implementations;

public class MacCheckbox : ICheckbox
{
    public void Paint()
    {
        Console.WriteLine("Renderizando um checkbox no estilo macOS");
    }
}