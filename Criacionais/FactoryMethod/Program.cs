using FactoryMethod.abstracts;
using FactoryMethod.implementations;

namespace FactoryMethod;

static class Program
{
    static void Main(string[] args)
    {
        Creator typeLogistic;

        Console.WriteLine("App: RoadLogistics");
        typeLogistic = new RoadLogistics();

        Console.WriteLine("Transport \n" + typeLogistic.TransportBox());
        Console.WriteLine("");

        Console.WriteLine("App: SeaLogistics");
        typeLogistic = new SeaLogistics();
        Console.WriteLine("Transport \n" + typeLogistic.TransportBox());
    }

}