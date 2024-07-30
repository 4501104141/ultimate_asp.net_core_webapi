namespace Shared.DataTransferObjects
{
    public record CompanyDto(Guid Id, string Name, string FullAddress);
    public record EmployeeDto(Guid Id, string Name, int Age, string Position);
}
