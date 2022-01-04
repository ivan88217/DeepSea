using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace DeepSea.Shared;
public partial class Confirm : ComponentBase
{
	protected bool ShowConfirmation { get; set; }

	[Parameter]
	public string ConfirmationTitle { get; set; } = "確認操作";

	[Parameter]
	public string ConfirmationMessage { get; set; } = "確定要刪除嗎?";

	public void Show()
	{
		ShowConfirmation = true;
		StateHasChanged();
	}

	[Parameter]
	public EventCallback<bool> ConfirmationChanged { get; set; }

	protected async Task OnConfirmationChange(bool value)
	{
		ShowConfirmation = false;
		await ConfirmationChanged.InvokeAsync(value);
	}
}
