
namespace Core.Lib.Config
{
    public interface IConfig
    {
        string StringGet(string key);
        string StringGet(string key, string defaultValue);
    }
}
