using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Lib.DependencyInjection
{
    public interface IFengBuilder
    {
        IServiceCollection Services { get; }
        IConfiguration Configuration { get; }
    }
}
