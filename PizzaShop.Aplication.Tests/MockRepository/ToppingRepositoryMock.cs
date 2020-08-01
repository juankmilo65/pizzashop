using Moq;
using PizzaShop.Aplication.Tests.DataMock;
using PizzaShop.Domain.Interfaces;

namespace PizzaShop.Aplication.Tests.MockRepository
{
    public class ToppingRepositoryMock
    {
        public Mock<IToppingRepository> _toppingRepository { get; set; }

        public ToppingRepositoryMock()
        {
            _toppingRepository = new Mock<IToppingRepository>();
            Setup();
        }

        private void Setup()
        {
            _toppingRepository.Setup((x) => x.GetToppings()).Returns(MockToppingRepository.GetToppings());
        }
    }
}
