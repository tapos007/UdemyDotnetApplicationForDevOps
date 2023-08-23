namespace UniversityManagementBackend.BLL.DbEntities;

public class Course
{
    public long CourseId { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    public decimal Credit { get; set; }
}