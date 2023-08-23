using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversityManagementBackend.BLL.DbEntities;

namespace UniversityManagementBackend.Database.Configs;

public class CourseConfiguration : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.Property(ts => ts.CourseId).ValueGeneratedNever();
        builder.HasData(
            new Course
            {
                CourseId = 1,
                Name = "Computer Fundamental",
                Code = "cs001",
                Credit = 3
            },
            new Course
            {
                CourseId = 2,
                Name = "Object Oriented Programming",
                Code = "cs002"
            });
    }
}