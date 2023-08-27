using Microsoft.AspNetCore.Mvc;
using UniversityManagementBackend.BLL.Interfaces.Services;
using UniversityManagementBackend.BLL.RequestDto;

namespace UniversityManagementBackend.API.Controllers;

[ApiController]
[Route("[controller]")]
public class CourseController : ControllerBase
{
    private readonly ICourseService _courseService;

   // some commit done
    public CourseController(ICourseService courseService)
    {
        _courseService = courseService;
    }

    [HttpGet]
    public async  Task<IActionResult> GetAll()
    {
        return Ok(await _courseService.GetAll());
    }
    
    [HttpGet("{id}")]
    public async  Task<IActionResult> GetA(long id)
    {
        return Ok(await _courseService.GetACourse(id));
    }
    
    [HttpPost]
    public async  Task<IActionResult> Insert(CourseEntryDto courseEntryDto)
    {
        return Ok(await _courseService.InsertCourse(courseEntryDto));
    }
    
    // some architecture changes done here
    // some modification needed
}