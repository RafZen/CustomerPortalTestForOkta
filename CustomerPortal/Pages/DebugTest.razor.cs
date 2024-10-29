
using Microsoft.AspNetCore.Components;


namespace CustomerPortal.Pages
{
    public partial class DebugTest:ComponentBase
    {
      
        protected override  async Task OnInitializedAsync()
        {
            await Task.Delay(1);
        }
    }
}

