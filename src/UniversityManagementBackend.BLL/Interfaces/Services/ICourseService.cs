using UniversityManagementBackend.BLL.DomainDto;

namespace UniversityManagementBackend.BLL.Interfaces.Services;

public interface ICourseService
{
    Task<List<CourseDto>> GetAll();
    Task<CourseDto> GetACourse(long id);
}