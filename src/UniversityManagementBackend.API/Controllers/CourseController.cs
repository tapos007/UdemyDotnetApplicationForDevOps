using Microsoft.AspNetCore.Mvc;
using UniversityManagementBackend.BLL.Interfaces.Services;

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
    
    // some architecture changes done here
    // some modification needed
}