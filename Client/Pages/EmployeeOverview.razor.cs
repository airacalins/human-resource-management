using HumanResourceManagement.Client.Models;

namespace HumanResourceManagement.Client.Pages
{
  public partial class EmployeeOverview
  {
    public List<Employee>? Employees { get; set; } = default!;

    private Employee? _selectedEmployee;

    protected override void OnInitialized()
    {
      Employees = MockDataService.Employees;
    }

    public void OnShowDetailsPopUp(Employee selectedEmployee)
    {
      _selectedEmployee = selectedEmployee;
    }

  }
}