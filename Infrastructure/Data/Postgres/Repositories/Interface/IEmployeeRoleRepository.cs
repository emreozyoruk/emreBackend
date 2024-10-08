using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Repositories.Base.Interface;

namespace Infrastructure.Data.Postgres.Repositories.Interface
{
    public interface IEmployeeRoleRepository : IRepository<EmployeeRole, int>
    {
        EmployeeRole GetByEmployeeAndRole(int employeeId, int roleId);
        bool Exists(int employeeId, int roleId);
    }
}
