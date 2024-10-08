﻿using Core.Utilities;
using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class DepartmentConfiguration : BaseConfiguration<Department, int>
    {
        public override void Configure(EntityTypeBuilder<Department> builder)
        {
            base.Configure(builder);

            var data = new Department[]
            {
                new Department{ Id = 1, Name="IT" },
                new Department{ Id = 2, Name="Human Resources" },
                new Department{ Id = 3, Name="Finance" }
            };

            builder.HasData(data);
        }
    }
}