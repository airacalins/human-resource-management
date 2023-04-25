using Microsoft.AspNetCore.Components;

namespace HumanResourceManagement.Client.Shared
{
  public partial class EmployeeCard
  {
    [Parameter]
    public Employee Employee { get; set; } = default!;

    [Parameter]
    public EventCallback<Employee> OnShowDetailsPopUp { get; set; }
  }
}