using UniversityManagementBackend.BLL.DomainDto;
using UniversityManagementBackend.BLL.RequestDto;

namespace UniversityManagementBackend.BLL.Interfaces.Services;

public interface ICourseService
{
    Task<List<CourseDto>> GetAll();
    Task<CourseDto> GetACourse(long id);
    Task<CourseDto> InsertCourse(CourseEntryDto courseEntryDto);
}