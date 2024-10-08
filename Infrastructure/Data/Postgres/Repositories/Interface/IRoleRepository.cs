using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Repositories.Base.Interface;

namespace Infrastructure.Data.Postgres.Repositories.Interface
{
    public interface IRoleRepository : IRepository<Role, int>
    {
        Role GetByName(string name);
        bool Exists(string name);
    }
}
