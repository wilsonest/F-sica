namespace Proyecto_Fisica;

public partial class ExamplesMain : ContentPage
{
	public ExamplesMain()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
    }

    private async void barber_Clicked(object sender, EventArgs e)
    {
        //await Navigation.PushAsync(new Page2());
    }
}