using Prototype.interfaces;

namespace Prototype.entities;

public class Person : IPrototype<Person>
{
    public int Age;
    public DateTime BirthDate;
    public string Name;
    public IdInfo IdInfo;

    public Person(int age, DateTime birthDate, string name, IdInfo idInfo)
    {
        Age = age;
        BirthDate = birthDate;
        Name = name;
        IdInfo = idInfo;
    }

    public Person Clone()
    {
        return new Person(Age, BirthDate, Name, IdInfo.Clone());
    }
}
