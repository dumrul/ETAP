using ETAP.Domain.Abstractions;

namespace ETAP.Domain.Entities
{
    public sealed class Organization : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<AppUser> Users { get; set; } = new HashSet<AppUser>();
        public ICollection<Activity> Activities { get; set; } = new HashSet<Activity>();
    }
}