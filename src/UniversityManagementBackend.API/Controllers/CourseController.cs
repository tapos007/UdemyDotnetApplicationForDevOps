using Microsoft.AspNetCore.Mvc;
using UniversityManagementBackend.BLL.Interfaces.Services;

namespace UniversityManagementBackend.API.Controllers;

[ApiController]
[Route("[controller]")]
public class CourseController : ControllerBase
{
    private readonly ICourseService _courseService;


    public CourseController(ICourseService courseService)
    {
        _courseService = courseService;
    }

    [HttpGet]
    public async  Task<IActionResult> GetAll()
    {
        return Ok(await _courseService.GetAll());
    }
}