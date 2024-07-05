using FactoryMethod.abstracts;
using FactoryMethod.interfaces;

namespace FactoryMethod.implementations;

public class RoadLogistics : Creator
{
    public override ITransport CreateTransport()
    {
        return new TruckTransport();
    }
}
