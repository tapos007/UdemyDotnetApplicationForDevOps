using UniversityManagementBackend.BLL.DomainDto;
using UniversityManagementBackend.BLL.Interfaces.Services;
using UniversityManagementBackend.BLL.Interfaces.UoF;
using UniversityManagementBackend.BLL.ViewObject.RequestObject;

namespace UniversityManagementBackend.BLL.Services;

public class DepartmentService : IDepartmentService
{
    private readonly IApplicationUow _uow;

    public DepartmentService(IApplicationUow uow)
    {
        _uow = uow;
    }
    public async Task<List<DepartmentDto>> GetAll()
    {
        var data =  await  _uow.DepartmentRepository.GetAll();
        return data.ToList();
    }

    public async Task<DepartmentDto> GetADepartment(long departmentId)
    {
        return await _uow.DepartmentRepository.FindFirstOne(x => x.DepartmentId == departmentId);
    }

    public async Task<DepartmentDto> DeleteDepartment(long departmentId)
    {
       var department =   await _uow.DepartmentRepository.FindFirstOne(x => x.DepartmentId == departmentId);
       if (department == null)
       {
           throw new Exception("department not found");
       }
       _uow.DepartmentRepository.Remove(department);
       await _uow.SaveChangesAsync();
       return department;
    }

    public async Task<DepartmentDto> UpdateDepartment(long departmentId, DepartmentEntryRequestViewModel departmentDto)
    {
        var department =   await _uow.DepartmentRepository.FindFirstOne(x => x.DepartmentId == departmentId);
        if (department == null)
        {
            throw new Exception("department not found");
        }
        
        if (departmentDto.Name != null)
        {
            department.Name = departmentDto.Name;
        }
        if (departmentDto.Code != null)
        {
            department.Code = departmentDto.Code;
        }
        
        _uow.DepartmentRepository.Update(department);
        
        await _uow.SaveChangesAsync();
        return department;
    }

    public async Task<DepartmentDto> AddDepartment(DepartmentEntryRequestViewModel departmentDto)
    {
        var department =   await _uow.DepartmentRepository
            .FindFirstOne(x => x.Name == departmentDto.Name ||  x.Code == departmentDto.Code);
        if (department != null)
        {
            throw new Exception("department name or code already exists");
        }

        var dep = new DepartmentDto()
        {
            Code = departmentDto.Code,
            Name = departmentDto.Name,
        };
        _uow.DepartmentRepository.Add(dep);
        await _uow.SaveChangesAsync();
        return dep;
    }
}