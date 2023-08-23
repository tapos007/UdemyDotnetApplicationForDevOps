using Microsoft.EntityFrameworkCore;
using UniversityManagementBackend.BLL.DbEntities;

namespace UniversityManagementBackend.BLL.Interfaces.DbContext;

public interface IApplicationDbContext
{
    public DbSet<Course> Courses { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Student> Students { get; set; }
}