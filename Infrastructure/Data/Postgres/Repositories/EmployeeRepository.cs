using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using System.Linq;

namespace Infrastructure.Data.Postgres.Repositories
{
    public class EmployeeRepository : Repository<Employee, int>, IEmployeeRepository
    {
        private readonly PostgresContext _context;

        public EmployeeRepository(PostgresContext postgresContext) : base(postgresContext)
        {
            _context = postgresContext;
        }

        // Email adresine göre Employee döndür
        public Employee GetByEmail(string email)
        {
            return _context.Employees.SingleOrDefault(employee => employee.Email == email);
        }

        // Employee'in veritabanında mevcut olup olmadığını kontrol et
        public bool Exists(string email)
        {
            return _context.Employees.Any(employee => employee.Email == email);
        }
    }
}
