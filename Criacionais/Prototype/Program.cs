
using Prototype.entities;
using Prototype.interfaces;

static class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person(29, new DateTime(1991, 1, 1), "Romulo Gouvea", new IdInfo(5000));

        Person p2 = p1.Clone();
        p2.IdInfo.IdNumber = 1000;
        p2.Name = "Cleverson Faria";

        Console.WriteLine("Pessoa Original:");
        DisplayValues(p1);

        Console.WriteLine("Pessoa Clonada após mudanças:");
        DisplayValues(p2);
    }

    public static void DisplayValues(Person p)
    {
        Console.WriteLine($"Nome: {p.Name}, Idade: {p.Age}, Data de aniversário: {p.BirthDate}");
        Console.WriteLine($"ID#: {p.IdInfo.IdNumber}");
    }
}