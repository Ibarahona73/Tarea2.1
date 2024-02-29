using System.Collections.Generic;

namespace Tarea2._1.Views;

public partial class Inicio : ContentPage
{
	public Inicio()
	{
		InitializeComponent();
	}

    private async void Sig_Clicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new Home());

    }
}