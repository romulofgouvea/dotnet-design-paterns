namespace Builder.entities;

public class Pizza
{
    public string Dough { get; set; }
    public string Sauce { get; set; }
    public string Topping { get; set; }

    public void Display()
    {
        Console.WriteLine($"Pizza: massa {Dough}, molho {Sauce} e cobertura de {Topping}.");
    }
}