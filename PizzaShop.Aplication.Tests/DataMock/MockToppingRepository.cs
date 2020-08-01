
using System.Collections.Generic;

namespace PizzaShop.Aplication.Tests.DataMock
{
    public static class MockToppingRepository
    {
        public static List<Dictionary<string, List<string>>> GetToppings()
        {
            List<Dictionary<string, List<string>>> mockList = new List<Dictionary<string, List<string>>>();

            List<string> toppingList = new List<string>();
            Dictionary<string, List<string>> mockDictionary = new Dictionary<string, List<string>>();
            toppingList.Add("diced tomatoes");
            toppingList.Add("four cheese");
            toppingList.Add("italian sausage");
            mockDictionary.Add("toppings", toppingList);
            mockList.Add(mockDictionary);

            toppingList = new List<string>();
            mockDictionary = new Dictionary<string, List<string>>();
            toppingList.Add("jalapenos");
            mockDictionary.Add("toppings", toppingList);
            mockList.Add(mockDictionary);

            toppingList = new List<string>();
            mockDictionary = new Dictionary<string, List<string>>();
            toppingList.Add("jalapenos");
            mockDictionary.Add("toppings", toppingList);
            mockList.Add(mockDictionary);

            toppingList = new List<string>();
            mockDictionary = new Dictionary<string, List<string>>();
            toppingList.Add("diced tomatoes");
            toppingList.Add("italian sausage");
            mockDictionary.Add("toppings", toppingList);
            mockList.Add(mockDictionary);

            toppingList = new List<string>();
            mockDictionary = new Dictionary<string, List<string>>();
            toppingList.Add("diced tomatoes");
            toppingList.Add("italian sausage");
            mockDictionary.Add("toppings", toppingList);
            mockList.Add(mockDictionary);

            return mockList;
        }
    }
}
