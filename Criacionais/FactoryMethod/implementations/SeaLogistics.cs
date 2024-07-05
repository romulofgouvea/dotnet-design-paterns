using FactoryMethod.abstracts;
using FactoryMethod.implementations;
using FactoryMethod.interfaces;

namespace FactoryMethod.implementations;

public class SeaLogistics : Creator
{
    public override ITransport CreateTransport()
    {
        return new ShipTransport();
    }
}