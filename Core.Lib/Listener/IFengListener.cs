using System.Threading.Tasks;

namespace Core.Lib.Listener
{
    public interface IFengListener
    {
        string ListenerName { get; }
        Task ExecuteAsync(string commandText);
    }
}
