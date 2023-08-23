namespace UniversityManagementBackend.BLL.DomainDto;

public class StudentDto
{
    public long StudentId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public long DepartmentId { get; set; }

    public DepartmentDto Department { get; set; }
}