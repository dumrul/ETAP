using Microsoft.AspNetCore.Identity;

namespace ETAP.Domain.Entities
{
    public sealed class AppUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName => $"{FirstName} {LastName}";

        public Guid OrganizationId { get; set; }
        public Organization? Organization { get; set; }
    }
}