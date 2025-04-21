using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace ETAP.Domain.Entities.Identity
{
    public sealed class AppUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;


        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";

        // Navigations
        public ICollection<Activity> OrganizedActivities { get; set; } = new List<Activity>();
        public ICollection<ActivityParticipant> ParticipatedActivities { get; set; } = new List<ActivityParticipant>();
        public Guid? OrganizationId { get; set; }
        public Organization? Organization { get; set; }
    }
}