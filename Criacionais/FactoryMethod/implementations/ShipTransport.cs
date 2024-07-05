using FactoryMethod.interfaces;

namespace FactoryMethod.implementations;

public class ShipTransport : ITransport
{
    public string Deliver()
    {
        return "mar";
    }
}