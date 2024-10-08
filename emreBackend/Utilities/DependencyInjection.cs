using Business.Services;
using Business.Services.Interface;
using Business.Utilities.Mapping;
using Business.Utilities.Mapping.Interface;
using Infrastructure.Data.Postgres;
using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Infrastructure.Data.Postgres.Repositories;

namespace Web.Utilities;

public static class DependencyInjection
{
    public static void AddMyScoped(this IServiceCollection serviceCollection)
    {
        // Add scoped services for Employee, Department, Role, and EmployeeRole
        serviceCollection.AddScoped<IEmployeeService, EmployeeService>();
        serviceCollection.AddScoped<IDepartmentService, DepartmentService>();
        serviceCollection.AddScoped<IRoleService, RoleService>();
        serviceCollection.AddScoped<IEmployeeRoleService, EmployeeRoleService>();

        // Add scoped repositories for Employee, Department, Role, and EmployeeRole
        serviceCollection.AddScoped<IEmployeeRepository, EmployeeRepository>();
        serviceCollection.AddScoped<IDepartmentRepository, DepartmentRepository>();
        serviceCollection.AddScoped<IRoleRepository, RoleRepository>();
        serviceCollection.AddScoped<IEmployeeRoleRepository, EmployeeRoleRepository>();

        // Add IUnitOfWork
        serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
    }

    public static void AddMySingleton(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        serviceCollection.AddSingleton<IMapperHelper, MapperHelper>();
        //serviceCollection.AddSingleton<IValidationHelper, ValidationHelper>();
        //serviceCollection.AddSingleton<IJwtTokenHelper, JwtTokenHelper>();
        //serviceCollection.AddSingleton<IHashingHelper, HashingHelper>();
    }

    public static void AddMyTransient(this IServiceCollection serviceCollection)
    {
    }
}
