using System.Net;
using System.Threading.Tasks;
using NUnit.Framework;
using SberPayAgent.Implementations.PayAgents;
using SberPayAgent.Model;
using SberPayAgent.Model.Enums;
using SberPayAgent.Model.Sberpay.RegisterOrderResponse;

namespace SberPayTests
{
    public class SberPayAgentTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SuccessAgentTest()
        {
            var result = PayAgentsFactory.Instance(new AppConfig() { UserRealAgent = true });
            Assert.IsNotNull(result);
            Assert.AreEqual(typeof(SberPayAgent.Implementations.PayAgents.SberPayAgent), result.GetType(), "Должен быть сконструирован реальный агент");
        }

        [Test]
        public void SuccessFakeAgentTest()
        {
            var result = PayAgentsFactory.Instance(new AppConfig() { UserRealAgent = false });
            Assert.IsNotNull(result);
            Assert.AreEqual(typeof(FakeSberPayAgent), result.GetType(), "Должен быть сконструирован  смоделированный агент");
        }

        [Test]
        public async Task SuccessFakeAgentMethodTest()
        {
            var result = PayAgentsFactory.Instance(new AppConfig() { UserRealAgent = false });
            var anser = await result.RegisterPreAuthAsync(new RegisterOrderRequestModel());
            Assert.IsNotNull(anser);
            Assert.AreEqual(HttpStatusCode.OK, anser.HttpStatus);
            Assert.AreEqual(ExternalResponseResultCodeEnum.Ok, anser.Status);
        }
    }
}