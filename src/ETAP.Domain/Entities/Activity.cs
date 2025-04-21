using ETAP.Domain.Enums;
using ETAP.Domain.Abstractions;
using ETAP.Domain.Entities.Identity;

namespace ETAP.Domain.Entities
{
    public sealed class Activity : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; } = string.Empty;

        // SmartEnum ile tanımlanan kategori ve durum
        public ActivityCategory Category { get; set; } = ActivityCategory.Meeting;
        public ActivityStatus Status { get; set; } = ActivityStatus.Planned;

        // Organizasyonu temsil eder
        public Guid OrganizationId { get; set; }
        public required Organization Organization { get; set; }

        // Etkinlik oluşturucusu (Organizatör)
        public Guid OrganizerId { get; set; }
        public required AppUser Organizer { get; set; }

        public ICollection<ActivityParticipant> Participants { get; set; }= new List<ActivityParticipant>();

        // Katılımcılarla ilişki kurulabilir, istersek ileride ekleriz
        // public ICollection<AppUser> Participants { get; set; } = new List<AppUser>();
    }
}