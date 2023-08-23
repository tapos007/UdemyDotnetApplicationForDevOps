namespace UniversityManagementBackend.BLL.DomainDto;

public class DepartmentDto
{
    public long DepartmentId { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }

    public List<StudentDto> Students { get; set; }
}