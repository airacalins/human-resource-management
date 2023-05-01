using System.Text.Json;

namespace HumanResourceManagement.Client.Services
{
  public class EmployeeService : IEmployeeService
  {
    private readonly HttpClient _httpClient;
    public EmployeeService(HttpClient httpClient)
    {
      _httpClient = httpClient;
    }

    public async Task<IEnumerable<Employee>> GetEmployees()
    {
      return await JsonSerializer.DeserializeAsync<IEnumerable<Employee>>(await _httpClient.GetStreamAsync($"api/employee"), new JsonSerializerOptions()
      {
        PropertyNameCaseInsensitive = true
      });
    }

    public async Task<Employee> GetEmployeeById(int id)
    {
      return await JsonSerializer.DeserializeAsync<Employee>(await _httpClient.GetStreamAsync($"api/employee/{id}"), new JsonSerializerOptions()
      {
        PropertyNameCaseInsensitive = true
      });
    }

    public Task<Employee> AddEmployee(Employee employee)
    {
      throw new NotImplementedException();
    }


    public Task UpdateEmployee(Employee employee)
    {
      throw new NotImplementedException();
    }

    public Task DeleteEmployee(int id)
    {
      throw new NotImplementedException();
    }





  }
}