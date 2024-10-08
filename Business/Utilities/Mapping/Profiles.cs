using AutoMapper;
using Business.Models.Request.Create;
using Business.Models.Request.Update;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Utilities.Mapping
{
    public class Profiles : Profile
    {
        public Profiles()
        {
            // CreateMap for Employee Entity and DTOs
            CreateMap<Employee, EmployeeResponseDTO>(); // Employee -> EmployeeResponseDTO mapping
            CreateMap<EmployeeCreateDTO, Employee>();   // EmployeeCreateDTO -> Employee mapping
            CreateMap<EmployeeUpdateDTO, Employee>();   // EmployeeUpdateDTO -> Employee mapping

            // CreateMap for Department Entity and DTOs
            CreateMap<Department, DepartmentResponseDTO>(); // Department -> DepartmentResponseDTO mapping
            CreateMap<DepartmentCreateDTO, Department>();   // DepartmentCreateDTO -> Department mapping
            CreateMap<DepartmentUpdateDTO, Department>();   // DepartmentUpdateDTO -> Department mapping

            // CreateMap for Role Entity and DTOs
            CreateMap<Role, RoleResponseDTO>(); // Role -> RoleResponseDTO mapping
            CreateMap<RoleCreateDTO, Role>();   // RoleCreateDTO -> Role mapping
            CreateMap<RoleUpdateDTO, Role>();   // RoleUpdateDTO -> Role mapping

            // CreateMap for EmployeeRole Entity and DTOs
            CreateMap<EmployeeRole, EmployeeRoleResponseDTO>(); // EmployeeRole -> EmployeeRoleResponseDTO mapping
            CreateMap<EmployeeRoleCreateDTO, EmployeeRole>();   // EmployeeRoleCreateDTO -> EmployeeRole mapping
            CreateMap<EmployeeRoleUpdateDTO, EmployeeRole>();   // EmployeeRoleUpdateDTO -> EmployeeRole mapping
        }
    }
}
