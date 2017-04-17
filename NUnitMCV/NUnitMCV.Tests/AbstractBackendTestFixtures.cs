using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using NUnit.Framework;

namespace NUnitMCV.Tests
{
    public abstract class AbstractBackendTestFixtures
    {
        protected HttpClient _client;
        protected TestServer _server;

        [SetUp]
        public void SetUp()
        {
            _server = new TestServer(new WebHostBuilder()
                .UseStartup<Backend.Startup>()
                .UseEnvironment("Testing"));
            _client = _server.CreateClient();
        }

        [TearDown]
        public void TearDown()
        {
            _client.Dispose();
            _server.Dispose();
        }
    }
}
