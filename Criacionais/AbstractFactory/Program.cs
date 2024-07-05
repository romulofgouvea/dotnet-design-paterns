using AbstractFactory.interfaces;
using AbstractFactory.implementations;

namespace AbstractFactory;

static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Cliente: Testando código do cliente com a fábrica Windows");
        GenerateLayout(new WinLayout());

        Console.WriteLine();

        Console.WriteLine("Cliente: Testando o mesmo código do cliente com a fábrica macOS");
        GenerateLayout(new MacLayout());
    }

    public static void GenerateLayout(IGUILayout layout)
    {
        var app = new Application(layout);
        app.CreateUI();
        app.PaintUI();
    }

}