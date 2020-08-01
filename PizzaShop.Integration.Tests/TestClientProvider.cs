using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using PizzaShop.Api;
using System.Net.Http;

namespace PizzaShop.Integration.Tests
{
    public class TestClientProvider
    {
        public HttpClient Client { get; set; }

        public TestClientProvider()
        {
            var server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = server.CreateClient();
        }
    }
}
