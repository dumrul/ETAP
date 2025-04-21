using Ardalis.SmartEnum;

namespace ETAP.Domain.Enums
{
    public sealed class ActivityStatusEnum : SmartEnum<ActivityStatusEnum>
    {
        public ActivityStatusEnum(string name, int value) : base(name, value)
        {
        }

        public static readonly ActivityStatusEnum Planned = new("Planlandı", 1);
        public static readonly ActivityStatusEnum Cancelled = new("İptal", 2);
        public static readonly ActivityStatusEnum Completed = new("Tamamlandı", 3);
    }
}