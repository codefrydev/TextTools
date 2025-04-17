using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace TextTools.Component.CSV;

public partial class CsvDialogue : ComponentBase
{
    [CascadingParameter]
    private IMudDialogInstance MudDialog { get; set; } = null!;

    private void Submit() => MudDialog.Close(DialogResult.Ok(true));

    private void Cancel() => MudDialog.Cancel();
}