using UniversityManagementBackend.BLL.DomainDto;
using UniversityManagementBackend.BLL.Interfaces.Services;
using UniversityManagementBackend.BLL.Interfaces.UoF;

namespace UniversityManagementBackend.BLL.Services;

public class CourseService : ICourseService
{
    private readonly IApplicationUow _uow;

    public CourseService(IApplicationUow uow)
    {
        _uow = uow;
    }


    public async Task<List<CourseDto>> GetAll()
    {
        var data =  await  _uow.CourseRepository.GetAll();
        return data.ToList();
    }

    public async Task<CourseDto> GetACourse(long id)
    {
        var data = await _uow.CourseRepository.FindFirstOne(x => x.CourseId == id);
        return data;
    }
}