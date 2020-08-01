using System.Collections.Generic;

namespace PizzaShop.Domain.Interfaces
{
    public interface IToppingRepository
    {
        List<Dictionary<string, List<string>>> GetToppings();
    }
}
