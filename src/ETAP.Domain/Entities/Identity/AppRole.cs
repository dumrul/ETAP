using Microsoft.AspNetCore.Identity;

namespace ETAP.Domain.Entities.Identity
{
    public sealed class AppRole : IdentityRole<Guid>
    {
        public AppRole(string roleName) : base(roleName)
        {
        }
    }
}