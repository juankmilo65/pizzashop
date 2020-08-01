using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace PizzaShop.Integration.Tests
{
    public class ToppingIntegrationTests
    {

        [Fact]
        public async Task GetRanking()
        {
            var client = new TestClientProvider().Client;

            var response = await client.GetAsync("/api/topping/1/2");
            response.EnsureSuccessStatusCode();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
