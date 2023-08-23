using Infrastructure.UnitOfWorkRepository.Contract;
using UniversityManagementBackend.BLL.DbEntities;
using UniversityManagementBackend.BLL.DomainDto;

namespace UniversityManagementBackend.BLL.Interfaces.Repositories;

public interface IDepartmentRepository : IGenericRepository<DepartmentDto,Department>
{
    
}