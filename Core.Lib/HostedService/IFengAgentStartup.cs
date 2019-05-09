using System.Threading;
using System.Threading.Tasks;

namespace Core.Lib.HostedService
{
    public interface IFengAgentStartup
    {
        Task StartAsync(CancellationToken cancellationToken = default);
        Task StopAsync(CancellationToken cancellationToken = default);
    }
}
