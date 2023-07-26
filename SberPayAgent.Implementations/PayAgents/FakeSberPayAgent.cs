using System.Net;
using System.Threading.Tasks;
using SberPayAgent.Interfaces.ExternalResponses;
using SberPayAgent.Interfaces.PayAgents;
using SberPayAgent.Model.Enums;
using SberPayAgent.Model.Sberpay.RegisterOrderResponse;
using SberPayAgent.WebModel.ExternalResponses;

namespace SberPayAgent.Implementations.PayAgents
{
    public class FakeSberPayAgent : ISberPayAgent
    {
        public async Task<IExternalAgentResponse<RegisterPreAuthResponseModel>> RegisterPreAuthAsync(RegisterOrderRequestModel order)
        {
            var result = new ExternalAgentResponse<RegisterPreAuthResponseModel>()
            {
                HttpStatus = HttpStatusCode.OK,
                Status = ExternalResponseResultCodeEnum.Ok
            };
            return await Task.FromResult(result);
        }
    }
}