namespace HumanResourceManagement.Client.Components
{
  public partial class Inbox
  {
    public int MessageCount { get; set; }
    protected override void OnInitialized()
    {
      MessageCount = new Random().Next(10);
    }
  }
}