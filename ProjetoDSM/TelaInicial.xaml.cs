using Microsoft.Maui.Controls;

namespace ProjetoDSM;

public partial class TelaInicial : ContentPage
{
    public TelaInicial()
    {
        InitializeComponent();
    }

    private async void OnEntrarClicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new MenuPrincipal());
    }
}
