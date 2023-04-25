using Microsoft.AspNetCore.Components;

namespace HumanResourceManagement.Client.Components
{
  public partial class QuickViewPopUp
  {
    [Parameter]
    public Employee? Employee { get; set; }

    private Employee? _selectedEmployee;

    protected override void OnParametersSet()
    {
      _selectedEmployee = Employee;
    }

    public void OnClose()
    {
      _selectedEmployee = null;
    }
  }
}

