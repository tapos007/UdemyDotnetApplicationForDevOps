using System.Data.Common;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using UniversityManagementBackend.BLL.DbEntities;
using UniversityManagementBackend.BLL.Interfaces.DbContext;
using UniversityManagementBackend.Database.Configs;

namespace UniversityManagementBackend.Database;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    private readonly IConfiguration _configuration;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> optionBuilder,
        IConfiguration configuration) : base(
        optionBuilder)
    {
        _configuration = configuration;
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(GetConnection()).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    }
    
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        RemovePluralizingTableNameConvention(modelBuilder);
        RemoveOneToManyAndManyToManyCascadeDeleteConventions(modelBuilder);

        ApplyConfiguration(modelBuilder);

        base.OnModelCreating(modelBuilder);
    }
    
    private DbConnection GetConnection()
    {
        var conn = new SqlConnection(_configuration["ConnectionStrings:ApplicationDbContext"]);
        return conn;
    }
    
    private void RemovePluralizingTableNameConvention(ModelBuilder modelBuilder)
    {
        foreach (IMutableEntityType entityType in modelBuilder.Model.GetEntityTypes())
        {
            entityType.SetTableName(entityType.DisplayName());
        }
    }
    
    private void RemoveOneToManyAndManyToManyCascadeDeleteConventions(ModelBuilder modelBuilder)
    {
        foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
        {
            relationship.DeleteBehavior = DeleteBehavior.Restrict;
        }
    }

    private void ApplyConfiguration(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CourseConfiguration());
    }

    public DbSet<Course> Courses { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Student> Students { get; set; }
}