using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha um tipo de pizza:");
            var tipoPizza = Console.ReadLine();

            Pizza pizza = null;
            switch (tipoPizza.ToUpper())
            {
                case "C":
                    pizza = new PizzaCalabresa();
                    break;
                case "P":
                    pizza = new PizzaPortuguesa();
                    break;
                default:
                    throw new ApplicationException("Não existe essa pizza em nosso cardápio.");
            }
            
            pizza.Preparar();
            pizza.IrParaOForno();
            pizza.Fatiar();
            pizza.Embalar();
            pizza.ProntaParaEntrega();
        }
    }
}
