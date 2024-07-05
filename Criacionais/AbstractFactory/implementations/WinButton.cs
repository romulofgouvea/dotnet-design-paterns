using AbstractFactory.interfaces;

namespace AbstractFactory.implementations;

public class WinButton : IButton
{
    public void Paint()
    {
        Console.WriteLine("Renderizando um botão no estilo Windows");
    }
}
