using Core.Utilities;
using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class RoleConfiguration : BaseConfiguration<Role, int>
    {
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            base.Configure(builder);

            var data = new Role[]
            {
                new Role{ Id = 1, Name="Admin", IsAdmin=true },
                new Role{ Id = 2, Name="Manager", IsAdmin=false },
                new Role{ Id = 3, Name="Employee", IsAdmin=false }
            };

            builder.HasData(data);
        }
    }
}
