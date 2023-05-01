using Microsoft.AspNetCore.Components;

namespace HumanResourceManagement.Client.Components
{
  public partial class Inbox
  {
    public int MessageCount { get; set; }

    [Inject]
    public ApplicationState ApplicationState { get; set; }

    protected override void OnInitialized()
    {
      MessageCount = ApplicationState.NumberOfMessages;
    }
  }
}