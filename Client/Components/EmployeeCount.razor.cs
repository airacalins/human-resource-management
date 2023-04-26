using HumanResourceManagement.Client.Models;

namespace HumanResourceManagement.Client.Components
{
  public partial class EmployeeCount
  {
    public int EmployeeCounter { get; set; }

    protected override void OnInitialized()
    {
      EmployeeCounter = MockDataService.Employees.Count;
    }
  }
}