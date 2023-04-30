using Microsoft.AspNetCore.Components;

namespace HumanResourceManagement.Client.Components
{
  public partial class EmployeeCard
  {
    [Parameter]
    public Employee Employee { get; set; } = default!;

    [Parameter]
    public EventCallback<Employee> OnShowDetailsPopUp { get; set; }

    [Inject]
    public NavigationManager NavigationManager { get; set; } = default!;

    protected override void OnInitialized()
    {
      if (string.IsNullOrEmpty(Employee.LastName))
      {
        throw new Exception("Last name can't be empty");
      }
    }

    public void NavigateToDetails(Employee selectedEmployee)
    {
      NavigationManager.NavigateTo($"/employees/{selectedEmployee.EmployeeId}");
    }
  }
}