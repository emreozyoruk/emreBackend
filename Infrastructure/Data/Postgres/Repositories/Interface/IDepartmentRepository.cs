﻿using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Repositories.Base.Interface;

namespace Infrastructure.Data.Postgres.Repositories.Interface
{
    public interface IDepartmentRepository : IRepository<Department, int>
    {
        Department GetByName(string name);
        bool Exists(string name);
    }
}