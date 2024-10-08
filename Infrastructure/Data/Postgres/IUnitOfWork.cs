﻿using Infrastructure.Data.Postgres.Repositories.Interface;
using System;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeRepository Employees { get; }
        IDepartmentRepository Departments { get; }
        IRoleRepository Roles { get; }
        IEmployeeRoleRepository EmployeeRoles { get; }

        Task<int> CommitAsync(); // Çalışanlara rol atanırken hem çalışan hem de rol tablolarında aynı anda değişiklik yapmayı sağlar
    }
}