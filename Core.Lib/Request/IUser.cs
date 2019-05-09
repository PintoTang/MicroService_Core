using System.Collections.Generic;
using System.Security.Claims;

namespace Core.Lib
{
    public interface IUser
    {
        string Id { get; }
        string Ids { get; }
        string Name { get; }
        string MobilePhone { get; }
        IEnumerable<Claim> Claims { get; }
    }
}
