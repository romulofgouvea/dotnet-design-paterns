using AbstractFactory.interfaces;

namespace AbstractFactory.implementations;

public class MacButton : IButton
{
    public void Paint()
    {
        Console.WriteLine("Renderizando um botão no estilo macOS");
    }
}