
using FactoryMethod.interfaces;

namespace FactoryMethod.implementations;

public class TruckTransport : ITransport
{
    public string Deliver() => "terra";
}