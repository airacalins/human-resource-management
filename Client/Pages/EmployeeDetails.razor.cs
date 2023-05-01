using HumanResourceManagement.Client.Models;
using HumanResourceManagement.Client.Services;
using Microsoft.AspNetCore.Components;

namespace HumanResourceManagement.Client.Pages
{
  public partial class EmployeeDetails
  {
    [Inject]
    public IEmployeeService? EmployeeService { get; set; }

    [Parameter]
    public string Id { get; set; } = String.Empty;

    public Employee? Employee { get; set; } = new Employee();

    protected override async Task OnInitializedAsync()
    {
      Employee = (await EmployeeService.GetEmployeeById(int.Parse(Id)));
    }
  }
}