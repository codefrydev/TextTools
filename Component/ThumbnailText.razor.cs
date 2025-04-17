using Microsoft.AspNetCore.Components;

namespace TextTools.Component;

public partial class ThumbnailText : ComponentBase
{
    [Parameter]
    public string? Text { get; set; }

    [Parameter]
    public string? Class { get; set; }

    [Parameter]
    public EventCallback<string> OnClick { get; set; }

    private async Task HandleClick()
    {
        if (OnClick.HasDelegate)
        {
            await OnClick.InvokeAsync(Text);
        }
    }
}