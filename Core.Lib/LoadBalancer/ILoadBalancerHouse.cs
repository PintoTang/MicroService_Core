using System.Threading.Tasks;

namespace Core.Lib.LoadBalancer
{
    public interface ILoadBalancerHouse
    {
        Task<ILoadBalancer> Get(string serviceName, string loadBalancer = "RoundRobin");
    }
}
