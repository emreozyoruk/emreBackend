using System;
using Business.Services.Base;
using Infrastructure.Data.Postgres;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;
using Business.Services.Interface;
using Business.Utilities.Mapping.Interface;

namespace Business.Services
{
    public class RoleService : BaseService<Role, int, RoleResponseDTO>, IRoleService
    {
        public RoleService(IUnitOfWork unitOfWork, IMapperHelper mapperHelper)
            : base(unitOfWork, unitOfWork.Roles, mapperHelper)
        {
        }
    }
}
