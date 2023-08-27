using UniversityManagementBackend.BLL.DomainDto;
using UniversityManagementBackend.BLL.Interfaces.Services;
using UniversityManagementBackend.BLL.Interfaces.UoF;
using UniversityManagementBackend.BLL.RequestDto;

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

    public async Task<CourseDto> InsertCourse(CourseEntryDto courseEntryDto)
    {
        var courseDto = new CourseDto()
        {
            Code = courseEntryDto.Code,
            Credit = courseEntryDto.Credit,
            Name = courseEntryDto.Name,
        };
        _uow.CourseRepository.Add(courseDto);
        await _uow.SaveChangesAsync();
        return courseDto;
    }
}