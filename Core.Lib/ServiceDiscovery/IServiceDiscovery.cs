namespace Core.Lib.ServiceDiscovery
{
    public interface IServiceDiscovery : IManageServiceInstances,
        IManageHealthChecks,
        IResolveServiceInstances,
        IHaveKeyValues
    {
    }
}
