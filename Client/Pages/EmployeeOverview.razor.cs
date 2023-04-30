using HumanResourceManagement.Client.Models;

namespace HumanResourceManagement.Client.Pages
{
  public partial class EmployeeOverview
  {
    public List<Employee>? Employees { get; set; } = default!;

    private Employee? _selectedEmployee;

    private string _title = "Employee Overview";

    protected override void OnInitialized()
    {
      Employees = MockDataService.Employees;
    }

    public void HandleShowDetailsPopUp(Employee selectedEmployee)
    {
      _selectedEmployee = selectedEmployee;
    }
  }
}