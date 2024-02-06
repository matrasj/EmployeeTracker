using AutoMapper;
using EmployeeTrackerApi.Employee;

namespace EmployeeTrackerApi.Helper;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<EmployeeEntity, EmployeeDto>();
        CreateMap<EmployeeDto, EmployeeEntity>();
    }
}