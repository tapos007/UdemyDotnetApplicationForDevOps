namespace UniversityManagementBackend.BLL.DbEntities;

public class Student
{
    public long StudentId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public long DepartmentId { get; set; }

    public Department Department { get; set; }
}