using Microsoft.EntityFrameworkCore;
using N5.Challenge.Domain;
using N5.Challenge.Domain.Entities;
using N5.Challenge.Persistence.Config;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace N5.Challenge.Persistence.Context
{
    public class DatabaseDbContext : DbContext
    {

        public DatabaseDbContext(DbContextOptions<DatabaseDbContext> options) : base(options)
        {
        }

        public DbSet<Permission> Permissions { get; set; }
        public DbSet<PermissionType> PermissionTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new PermissionConfig(modelBuilder.Entity<Permission>());
            new PermissionTypeConfig(modelBuilder.Entity<PermissionType>());
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedAt = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.UpdatedAt = DateTime.Now;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
