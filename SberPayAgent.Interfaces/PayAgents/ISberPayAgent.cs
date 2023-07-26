using System.Threading.Tasks;
using SberPayAgent.Interfaces.ExternalResponses;
using SberPayAgent.Model.Sberpay.RegisterOrderResponse;

namespace SberPayAgent.Interfaces.PayAgents
{
    public interface ISberPayAgent
    {
        Task<IExternalAgentResponse<RegisterPreAuthResponseModel>> RegisterPreAuthAsync(RegisterOrderRequestModel order);
    }
}
