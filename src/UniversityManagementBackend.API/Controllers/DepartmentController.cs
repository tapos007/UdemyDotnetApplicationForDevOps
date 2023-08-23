using Microsoft.AspNetCore.Mvc;
using UniversityManagementBackend.BLL.DomainDto;
using UniversityManagementBackend.BLL.Interfaces.Services;
using UniversityManagementBackend.BLL.ViewObject.RequestObject;

namespace UniversityManagementBackend.API.Controllers;

[ApiController]
[Route("[controller]")]
public class DepartmentController : ControllerBase
{
    private readonly IDepartmentService _departmentService;

    public DepartmentController(IDepartmentService departmentService)
    {
        _departmentService = departmentService;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        return  Ok(await _departmentService.GetAll());
    }
    
    [HttpGet("{departmentId}")]
    public async Task<IActionResult> GetADepartment(long departmentId)
    {
        return  Ok(await _departmentService.GetADepartment(departmentId));
    }
    
    [HttpDelete("{departmentId}")]
    public async Task<IActionResult> DeleteDepartment(long departmentId)
    { 
        
        return  Ok(await _departmentService.DeleteDepartment(departmentId));
    }
    
    [HttpPut("{departmentId}")]
    public async Task<IActionResult> UpdateDepartment(long departmentId,DepartmentEntryRequestViewModel department)
    {
        return  Ok(await _departmentService.UpdateDepartment(departmentId,department));
    }
    
    [HttpPost]
    public async Task<IActionResult> InsertDepartment(DepartmentEntryRequestViewModel department)
    {
        return  Ok(await _departmentService.AddDepartment(department));
    }
}