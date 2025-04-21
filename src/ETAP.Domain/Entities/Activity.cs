using ETAP.Domain.Enums;
using ETAP.Domain.Abstractions;

namespace ETAP.Domain.Entities
{
    public sealed class Activity : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // SmartEnum ile tanımlanan kategori ve durum
        public ActivityCategoryEnum Category { get; set; } = ActivityCategoryEnum.Meeting;
        public ActivityStatusEnum Status { get; set; } = ActivityStatusEnum.Planned;

        // Organizasyonu temsil eder
        public Guid OrganizationId { get; set; }
        public Organization? Organization { get; set; }

        // Etkinlik oluşturucusu (Organizatör)
        public Guid OrganizerId { get; set; }
        public AppUser? Organizer { get; set; }

        // Katılımcılarla ilişki kurulabilir, istersek ileride ekleriz
        // public ICollection<AppUser> Participants { get; set; } = new List<AppUser>();
    }
}