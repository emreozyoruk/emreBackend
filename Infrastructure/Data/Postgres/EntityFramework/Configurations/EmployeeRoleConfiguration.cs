using Core.Utilities;
using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class EmployeeRoleConfiguration : BaseConfiguration<EmployeeRole, int>
    {
        public override void Configure(EntityTypeBuilder<EmployeeRole> builder)
        {
            base.Configure(builder);

            // Seed data for EmployeeRole, using negative Id values to avoid collisions
            var data = new EmployeeRole[]
            {
                new EmployeeRole { Id = -1, EmployeeId = 1, RoleId = 1 }, // Employee 1, Role 1 (Admin)
                new EmployeeRole { Id = -2, EmployeeId = 2, RoleId = 2 }, // Employee 2, Role 2 (User)
                new EmployeeRole { Id = -3, EmployeeId = 3, RoleId = 1 }  // Employee 3, Role 1 (Admin)
            };

            builder.HasData(data);
        }
    }
}
