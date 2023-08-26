using UdemyInfrastructure.UnitOfWorkRepository;
using UniversityManagementBackend.BLL.Interfaces.Repositories;
using UniversityManagementBackend.BLL.Interfaces.UoF;
using UniversityManagementBackend.Database;
using UniversityManagementBackend.DLL.Repository;

namespace UniversityManagementBackend.DLL.UoF;

public class ApplicationUow : BaseUnitOfWork,IApplicationUow
{

    public ApplicationUow(IServiceProvider serviceProvider,
        ApplicationDbContext contextFactory) : base(
        contextFactory)
    {
        CourseRepository = new CourseRepository(contextFactory, serviceProvider);
        DepartmentRepository = new DepartmentRepository(contextFactory, serviceProvider);
        DepartmentRepository = new DepartmentRepository(contextFactory, serviceProvider);
    }

    public ICourseRepository CourseRepository { get; }
    public IStudentRepository StudentRepository { get; }
    public IDepartmentRepository DepartmentRepository { get; }
}