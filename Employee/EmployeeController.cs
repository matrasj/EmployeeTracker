using AutoMapper;
using Microsoft.AspNetCore.Mvc;
namespace EmployeeTrackerApi.Employee;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{
    private readonly IMapper _mapper;

    public EmployeeController(IMapper mapper)
    {
        _mapper = mapper;
    }
    
    [HttpGet]
    [ProducesResponseType(200, Type = typeof(EmployeeDto))]
    public IActionResult GetTestEmployee()
    {
        var testEmployee = _mapper.Map<EmployeeDto>(new EmployeeEntity(1, "Kuba", "Matras"));
        
        return Ok(testEmployee);
    }
}