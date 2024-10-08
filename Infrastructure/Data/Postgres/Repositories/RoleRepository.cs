using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using System.Linq;

namespace Infrastructure.Data.Postgres.Repositories
{
    public class RoleRepository : Repository<Role, int>, IRoleRepository
    {
        private readonly PostgresContext _context;

        public RoleRepository(PostgresContext postgresContext) : base(postgresContext)
        {
            _context = postgresContext;
        }

        // Rol adına göre Role döndür
        public Role GetByName(string name)
        {
            return _context.Roles.SingleOrDefault(role => role.Name == name);
        }

        // Role'ün veritabanında mevcut olup olmadığını kontrol et
        public bool Exists(string name)
        {
            return _context.Roles.Any(role => role.Name == name);
        }
    }
}
