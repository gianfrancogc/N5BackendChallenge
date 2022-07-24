using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using N5.Challenge.Domain.Entities;

namespace N5.Challenge.Persistence.Config
{
    public class PermissionConfig
    {
        public PermissionConfig(EntityTypeBuilder<Permission> entityType)
        {
            entityType.Property(x => x.EmployeeName).HasColumnType("varchar(250)").IsRequired();
            entityType.Property(x => x.EmployeeLastname).HasColumnType("varchar(250)").IsRequired();
        }
    }
}
