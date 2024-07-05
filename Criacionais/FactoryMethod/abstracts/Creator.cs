using FactoryMethod.interfaces;

namespace FactoryMethod.abstracts;

public abstract class Creator
{

    public abstract ITransport CreateTransport();


    public string TransportBox()
    {
        var transport = CreateTransport();
        return $"Entrega do pacote por {transport.Deliver()}";
    }
}
