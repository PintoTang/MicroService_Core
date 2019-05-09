using Core.Lib.Values;
using System.Threading.Tasks;

namespace Core.Lib.LoadBalancer
{
    public interface ILoadBalancer
    {
        Task<HostAndPort> Lease();
        void Release(HostAndPort hostAndPort);
    }
}
