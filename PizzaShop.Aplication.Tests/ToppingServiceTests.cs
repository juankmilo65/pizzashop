using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PizzaShop.Aplication.Interfaces;
using PizzaShop.Aplication.Services;
using PizzaShop.Aplication.Tests.MockRepository;
using PizzaShop.Domain.Interfaces;
using System;
using System.Linq;

namespace PizzaShop.Aplication.Tests
{
    [TestClass]
    public class ToppingServiceTests
    {
        private static IToppingService _toppingService;

        [ClassInitialize()]
        public static void Setup(TestContext context)
        {
            Mock<IToppingRepository> _toppingRepository = new ToppingRepositoryMock()._toppingRepository;
            _toppingService = new ToppingService(_toppingRepository.Object);
        }

        [TestMethod]
        public void GetToppingsWithPageIndexAndPageSize()
        {
            //Arrange
            int pageIndex = 1;
            int pageSize = 2;

            //Act
            var result = _toppingService.GetToppings(pageIndex, pageSize);

            //Asserts
            result.Items.Count.Should().Be(pageSize);
            result.Items.FirstOrDefault().Topping.Should().Be("diced tomatoes, italian sausage");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Page index can not be 0.")]
        public void GetToppingsWithoutPageIndex()
        {
            //Arrange
            int pageIndex = 0;
            int pageSize = 0;

            //Act
            _toppingService.GetToppings(pageIndex, pageSize);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Page size can not be 0.")]
        public void GetToppingsWithoutPageSize()
        {
            //Arrange
            int pageIndex = 1;
            int pageSize = 0;

            //Act
            _toppingService.GetToppings(pageIndex, pageSize);
        }
    }
}
