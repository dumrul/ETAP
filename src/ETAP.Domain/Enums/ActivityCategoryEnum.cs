using Ardalis.SmartEnum;

namespace ETAP.Domain.Enums
{
    public sealed class ActivityCategoryEnum : SmartEnum<ActivityCategoryEnum>
    {
        public ActivityCategoryEnum(string name, int value) : base(name, value)
        {
        }

        public static readonly ActivityCategoryEnum Meeting = new("Toplantı", 1);
        public static readonly ActivityCategoryEnum Seminar = new("Seminer", 2);
        public static readonly ActivityCategoryEnum Workshop = new("Çalıştay", 3);
        public static readonly ActivityCategoryEnum Training = new("Eğitim", 4);
    }
}