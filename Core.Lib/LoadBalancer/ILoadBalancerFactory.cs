using System.Threading.Tasks;

namespace Core.Lib.LoadBalancer
{
    public interface ILoadBalancerFactory
    {
        Task<ILoadBalancer> Get(string serviceName, string _LoadBalancer);
    }
}
