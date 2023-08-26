using UdemyInfrastructure.UnitOfWorkRepository;
using UniversityManagementBackend.BLL.DbEntities;
using UniversityManagementBackend.BLL.DomainDto;
using UniversityManagementBackend.BLL.Interfaces.Repositories;
using UniversityManagementBackend.Database;

namespace UniversityManagementBackend.DLL.Repository;

public class DepartmentRepository : BaseGenericRepository<DepartmentDto,Department>,IDepartmentRepository
{
    private readonly ApplicationDbContext _context;

    public DepartmentRepository(ApplicationDbContext context, IServiceProvider serviceProvider) : base(context, serviceProvider)
    {
        _context = context;
    }
}