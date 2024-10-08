using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using System.Linq;

namespace Infrastructure.Data.Postgres.Repositories
{
    public class EmployeeRoleRepository : Repository<EmployeeRole, int>, IEmployeeRoleRepository
    {
        private readonly PostgresContext _context;

        public EmployeeRoleRepository(PostgresContext postgresContext) : base(postgresContext)
        {
            _context = postgresContext;
        }

        // EmployeeId ve RoleId'ye göre EmployeeRole döndür
        public EmployeeRole GetByEmployeeAndRole(int employeeId, int roleId)
        {
            return _context.EmployeeRoles
                           .SingleOrDefault(er => er.EmployeeId == employeeId && er.RoleId == roleId);
        }

        // EmployeeRole ilişkisi veritabanında mevcut olup olmadığını kontrol et
        public bool Exists(int employeeId, int roleId)
        {
            return _context.EmployeeRoles
                           .Any(er => er.EmployeeId == employeeId && er.RoleId == roleId);
        }
    }
}
