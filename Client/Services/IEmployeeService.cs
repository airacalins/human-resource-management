namespace HumanResourceManagement.Client.Services
{
  public interface IEmployeeService
  {
    Task<IEnumerable<Employee>> GetEmployees();
    Task<Employee> GetEmployeeById(int id);
    Task<Employee> AddEmployee(Employee employee);
    Task UpdateEmployee(Employee employee);
    Task DeleteEmployee(int id);
  }
}