using AutoMapper;
using UniversityManagementBackend.BLL.DbEntities;
using UniversityManagementBackend.BLL.DomainDto;

namespace UniversityManagementBackend.BLL.MappingProfile;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<CourseDto, Course>().ReverseMap();
        CreateMap<StudentDto, Student>().ReverseMap();
        CreateMap<DepartmentDto, Department>().ReverseMap();
    }
}