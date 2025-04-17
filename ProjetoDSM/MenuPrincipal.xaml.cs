using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;


namespace ProjetoDSM;

public partial class MenuPrincipal : Microsoft.Maui.Controls.TabbedPage
{
	public MenuPrincipal()
	{
		InitializeComponent();
		On<Microsoft.Maui.Controls.PlatformConfiguration.Android>()
			.SetToolbarPlacement(ToolbarPlacement.Bottom);
	}
}