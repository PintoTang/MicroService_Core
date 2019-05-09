using System.Threading;
using System.Threading.Tasks;

namespace Core.Lib.HostedService
{
    public interface IExecutionService
    {
        Task StartAsync(CancellationToken cancellationToken = default);

        Task StopAsync(CancellationToken cancellationToken = default);
    }
}
