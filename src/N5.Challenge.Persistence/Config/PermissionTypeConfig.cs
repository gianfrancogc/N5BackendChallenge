using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using N5.Challenge.Domain.Entities;

namespace N5.Challenge.Persistence.Config
{
    public class PermissionTypeConfig
    {
        public PermissionTypeConfig(EntityTypeBuilder<PermissionType> entityType)
        {
            entityType.Property(x => x.Description).HasColumnType("varchar(300)").IsRequired();

            entityType.HasMany(x => x.Permissions)
                .WithOne(x => x.PermissionType)
                .HasForeignKey(x => x.PermissionTypeId)
                .IsRequired();

        }
    }
}
