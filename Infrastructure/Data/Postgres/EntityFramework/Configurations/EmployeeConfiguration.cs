using Core.Utilities;
using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class EmployeeConfiguration : BaseConfiguration<Employee, int>
    {
        public override void Configure(EntityTypeBuilder<Employee> builder)
        {
            base.Configure(builder);

            var data = new Employee[]
            {
                new Employee{ Id = 1, FullName="Emre Öz", Email="emre@company.com", Phone="05550000000", DepartmentId=1 },
                new Employee{ Id = 2, FullName="Batuhan Yıldırım", Email="batuhan@company.com", Phone="05551111111", DepartmentId=2 },
                new Employee{ Id = 3, FullName="Ziya Koç", Email="ziya@company.com", Phone="05552222222", DepartmentId=3 }
            };

            builder.HasData(data);
        }
    }
}
