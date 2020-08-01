using PizzaShop.Aplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Aplication.Interfaces
{
    public interface IToppingService
    {
        PaginationDTO GetToppings(int pageIndex, int pageSize);
    }
}
