using Microsoft.AspNetCore.Components;

namespace HumanResourceManagement.Client.Shared
{
  public partial class QuickViewPopUp
  {
    [Parameter]
    public Employee? Employee { get; set; }

    private Employee? _employee;

    protected override void OnParametersSet()
    {
      _employee = Employee;
    }

    public void OnClose()
    {
      _employee = null;
    }
  }
}

