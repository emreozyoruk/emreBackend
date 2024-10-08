using System;
using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Role : Entity<int>
    {
        public string Name { get; set; }
        public bool IsAdmin { get; set; }
        public ICollection<EmployeeRole> EmployeeRoles { get; set; }
    }
}

