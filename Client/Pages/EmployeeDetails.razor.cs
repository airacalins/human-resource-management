using HumanResourceManagement.Client.Models;
using Microsoft.AspNetCore.Components;

namespace HumanResourceManagement.Client.Pages
{
  public partial class EmployeeDetails
  {
    [Parameter]
    public string Id { get; set; } = String.Empty;

    public Employee? Employee { get; set; } = new Employee();

    protected override Task OnInitializedAsync()
    {
      Employee = MockDataService.Employees.FirstOrDefault(employee => employee.EmployeeId == int.Parse(Id));

      return base.OnInitializedAsync();
    }
  }
}