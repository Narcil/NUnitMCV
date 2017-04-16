using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NUnit.Framework;

namespace NUnitMCV.Tests
{
    [TestFixture]
    public class BackendControllerTests : AbstractBackendTestFixtures
    {
        [Test]
        public async Task BackendAppSettingsTest()
        {
            //SetUp();
            var response = await _client.GetAsync("/api/values");
            var value = JsonConvert.DeserializeObject<string>(await response.Content.ReadAsStringAsync());

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.IsTrue(value.Equals("Some BackendValue"));
        }

    }
}
