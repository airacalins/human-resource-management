using Microsoft.AspNetCore.Components;

namespace HumanResourceManagement.Client.Components
{
  public partial class ProfilePicture
  {
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
  }
}