namespace EmployeeTrackerApi.Employee;

public class EmployeeEntity(int Id, string firstname, string lastname)
{
    public int Id { get; init; }
    public string Firstname { get; init; } = firstname;
    public string Lastname { get; init; } = lastname;
}