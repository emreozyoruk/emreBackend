using System;
using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Department : Entity<int>
    {
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}

