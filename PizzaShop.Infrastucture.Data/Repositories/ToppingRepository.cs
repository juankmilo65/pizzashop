using PizzaShop.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace PizzaShop.Infrastructure.Data.Repositories
{
    public class ToppingRepository : IToppingRepository
    {
        public List<Dictionary<string, List<string>>> GetToppings()
        {
            try
            {
                Client _client = new Client();
                return _client.GetToppings();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
    }
}
