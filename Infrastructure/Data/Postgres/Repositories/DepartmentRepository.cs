using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using System.Linq;

namespace Infrastructure.Data.Postgres.Repositories
{
    public class DepartmentRepository : Repository<Department, int>, IDepartmentRepository
    {
        private readonly PostgresContext _context;

        public DepartmentRepository(PostgresContext postgresContext) : base(postgresContext)
        {
            _context = postgresContext;
        }

        // Departman adına göre Department döndür
        public Department GetByName(string name)
        {
            return _context.Departments.SingleOrDefault(department => department.Name == name);
        }

        // Department'ın veritabanında mevcut olup olmadığını kontrol et
        public bool Exists(string name)
        {
            return _context.Departments.Any(department => department.Name == name);
        }
    }
}
