using Prototype.interfaces;

namespace Prototype.entities;

public class IdInfo : IPrototype<IdInfo>
{
    public int IdNumber;

    public IdInfo(int idNumber)
    {
        IdNumber = idNumber;
    }

    public IdInfo Clone()
    {
        return new IdInfo(IdNumber);
    }
}