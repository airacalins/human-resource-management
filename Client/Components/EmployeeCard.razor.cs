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

    public void NavigateToDetails(Employee selectedEmployee)
    {
      NavigationManager.NavigateTo($"/employees/{selectedEmployee.EmployeeId}");
    }
  }
}