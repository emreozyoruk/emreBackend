using System;
using Business.Services.Base;
using Infrastructure.Data.Postgres;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;
using Business.Services.Interface;
using Business.Utilities.Mapping.Interface;

namespace Business.Services
{
    public class EmployeeService : BaseService<Employee, int, EmployeeResponseDTO>, IEmployeeService
    {
        public EmployeeService(IUnitOfWork unitOfWork, IMapperHelper mapperHelper)
            : base(unitOfWork, unitOfWork.Employees, mapperHelper)
        {
        }
    }
}
