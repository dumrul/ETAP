using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETAP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ETAP.Infrastructure.Persistence.Configurations
{
public class UserTokenConfiguration : IEntityTypeConfiguration<UserToken>
{
    public void Configure(EntityTypeBuilder<UserToken> builder)
    {
        builder.ToTable("UserTokens");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.RefreshToken)
               .IsRequired()
               .HasMaxLength(500);

        builder.Property(x => x.ExpiresAt)
               .IsRequired();

        builder.Property(x => x.IsRevoked)
               .HasDefaultValue(false);

        builder.HasOne(x => x.User)
               .WithMany()
               .HasForeignKey(x => x.UserId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
}