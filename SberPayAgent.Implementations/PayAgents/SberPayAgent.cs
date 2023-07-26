using System.Threading.Tasks;
using SberPayAgent.Interfaces.ExternalResponses;
using SberPayAgent.Interfaces.PayAgents;
using SberPayAgent.Model.Sberpay.RegisterOrderResponse;

namespace SberPayAgent.Implementations.PayAgents
{
    public class SberPayAgent : ISberPayAgent
    {
        public Task<IExternalAgentResponse<RegisterPreAuthResponseModel>> RegisterPreAuthAsync(RegisterOrderRequestModel order)
        {
            throw new System.NotImplementedException();
        }
    }
}