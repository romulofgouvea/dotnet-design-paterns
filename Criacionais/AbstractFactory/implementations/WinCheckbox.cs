using AbstractFactory.interfaces;

namespace AbstractFactory.implementations;

public class WinCheckbox : ICheckbox
{
    public void Paint()
    {
        Console.WriteLine("Renderizando um checkbox no estilo Windows");
    }
}
