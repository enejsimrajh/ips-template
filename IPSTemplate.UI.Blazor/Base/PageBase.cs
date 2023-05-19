using Microsoft.Extensions.Localization;

namespace IPSDiva.Ui.Blazor;

public abstract class PageBase : ComponentBase
{
    [Inject] internal IStringLocalizer<IPSTemplate.UI.Blazor.Properties.Resources> Localizer { get; set; } = default!;
}
