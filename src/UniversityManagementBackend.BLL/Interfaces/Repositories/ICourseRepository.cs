using Infrastructure.UnitOfWorkRepository.Contract;
using UniversityManagementBackend.BLL.DbEntities;
using UniversityManagementBackend.BLL.DomainDto;

namespace UniversityManagementBackend.BLL.Interfaces.Repositories;

public interface ICourseRepository : IGenericRepository<CourseDto,Course>
{
    
}