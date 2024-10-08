using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Repositories.Base.Interface;

namespace Infrastructure.Data.Postgres.Repositories.Interface
{
    public interface IEmployeeRepository : IRepository<Employee, int>
    {
        Employee GetByEmail(string email);
        bool Exists(string email);
    }
}
