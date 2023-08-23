using UniversityManagementBackend.BLL.DomainDto;
using UniversityManagementBackend.BLL.ViewObject.RequestObject;

namespace UniversityManagementBackend.BLL.Interfaces.Services;

public interface IDepartmentService
{
    Task<List<DepartmentDto>> GetAll();
    Task<DepartmentDto> GetADepartment(long departmentId);
    Task<DepartmentDto> DeleteDepartment(long departmentId);
    Task<DepartmentDto> UpdateDepartment(long departmentId, DepartmentEntryRequestViewModel departmentDto);
    Task<DepartmentDto> AddDepartment(DepartmentEntryRequestViewModel departmentDto);
}