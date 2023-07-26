using SberPayAgent.Interfaces.PayAgents;
using SberPayAgent.Model;

namespace SberPayAgent.Implementations.PayAgents
{
    public class PayAgentsFactory
    {
        public static ISberPayAgent Instance(AppConfig config)
        {
            ISberPayAgent result;
            if (config.UserRealAgent)
            {
                result = new SberPayAgent();
            }
            else
            {
                result = new FakeSberPayAgent();
            }

            return result;
        }
    }
}