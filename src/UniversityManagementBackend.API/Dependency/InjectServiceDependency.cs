
using Microsoft.EntityFrameworkCore;
using UdemyInfrastructure.UnitOfWorkRepository;
using UdemyInfrastructure.UnitOfWorkRepository.Contract;
using UniversityManagementBackend.BLL.DbEntities;
using UniversityManagementBackend.BLL.DomainDto;
using UniversityManagementBackend.BLL.Interfaces.DbContext;
using UniversityManagementBackend.BLL.Interfaces.Services;
using UniversityManagementBackend.BLL.Interfaces.UoF;
using UniversityManagementBackend.BLL.Services;
using UniversityManagementBackend.Database;
using UniversityManagementBackend.DLL.UoF;

namespace UniversityManagementBackend.API.Dependency;

public static class InjectServiceDependency
{
    public static IServiceCollection ServiceInjectDependency(this IServiceCollection serviceCollection)
    {

        serviceCollection.AddScoped<ICourseService, CourseService>();
        serviceCollection.AddScoped<IDepartmentService, DepartmentService>();
        serviceCollection.AddScoped<IApplicationDbContext, ApplicationDbContext>();
        serviceCollection.AddScoped<IApplicationUow, ApplicationUow>();
        return serviceCollection;
    }
    
    public static IServiceCollection RegisterObjectInjectDependency(this IServiceCollection serviceCollection)
    {

        serviceCollection.RegisterObjectConverter<CourseDto, Course>();
        serviceCollection.RegisterObjectConverter<StudentDto, Student>();
        serviceCollection.RegisterObjectConverter<DepartmentDto, Department>();
        return serviceCollection;
    }
    
    
    
    public static IServiceCollection RegisterObjectConverter<TDto, TDb>(this IServiceCollection services) where TDb : class where TDto : class
    {
        services.AddTransient<IObjectConverter<TDto, TDb>, ObjectConverter<TDto, TDb>>();
        return services;
    }
    
    public static void PerformDbMigration(this WebApplication app)
    {
        var scope = app.Services.CreateAsyncScope();
        using var db = scope.ServiceProvider.GetService<ApplicationDbContext>();
         db.Database.Migrate();
       
    }
}