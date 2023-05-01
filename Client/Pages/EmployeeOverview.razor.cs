using HumanResourceManagement.Client.Models;
using HumanResourceManagement.Client.Services;
using Microsoft.AspNetCore.Components;

namespace HumanResourceManagement.Client.Pages
{
  public partial class EmployeeOverview
  {
    [Inject]
    public IEmployeeService? EmployeeService { get; set; }

    public List<Employee>? Employees { get; set; } = default!;

    private Employee? _selectedEmployee;

    private string _title = "Employee Overview";

    protected override async Task OnInitializedAsync()
    {
      Employees = (await EmployeeService.GetEmployees()).ToList();
    }

    public void HandleShowDetailsPopUp(Employee selectedEmployee)
    {
      _selectedEmployee = selectedEmployee;
    }
  }
}