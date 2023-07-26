using Microsoft.Extensions.Logging;

namespace SberPayAgent.Interfaces
{
    public interface ILoggedInstance
    {
        ILogger Logger { get; } 
    }
}