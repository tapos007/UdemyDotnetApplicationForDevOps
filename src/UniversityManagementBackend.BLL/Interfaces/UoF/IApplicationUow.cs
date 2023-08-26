
using UdemyInfrastructure.UnitOfWorkRepository.Contract;
using UniversityManagementBackend.BLL.Interfaces.Repositories;

namespace UniversityManagementBackend.BLL.Interfaces.UoF;

public interface IApplicationUow : IUnityOfWork
{
    ICourseRepository CourseRepository { get; }
    IStudentRepository StudentRepository { get; }
    IDepartmentRepository DepartmentRepository { get; }
}