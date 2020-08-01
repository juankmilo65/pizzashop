using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using PizzaShop.Aplication.Interfaces;
using PizzaShop.Aplication.Models;

namespace PizzaShop.Api.Controllers
{

    [Route("api/topping")]
    [ApiController]
    public class ToppingController : Controller
    {

        private IToppingService _toppingService;
        public ToppingController(IToppingService toppingService)
        {
            _toppingService = toppingService;
        }

        /// <summary>
        /// Test method to check if service is running.
        /// </summary>
        /// <returns>String "Services Ok".</returns>
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Services Ok";
        }


        /// <summary>
        /// Method to get paginated toppings.
        /// </summary>
        /// <param name="pageIndex">Current page.</param>
        /// <param name="pageSize">Listing size.</param>
        /// <returns>Ranking toppings listing by page.</returns>
        [HttpGet("{pageIndex}/{pageSize}")]
        public ActionResult<PaginationDTO> GetRanking(int pageIndex, int pageSize)
        {
            return _toppingService.GetToppings(pageIndex, pageSize);
        }
    }
}
