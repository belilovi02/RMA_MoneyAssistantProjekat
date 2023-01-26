namespace RMA_MoneyAssistant.Pages;

public partial class HelloPage : ContentPage
{
	public HelloPage()
	{
		InitializeComponent();
	}
    private async void OnLoginClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new LoginPage(null));
    }
    private void OnSignupClicked(object sender, EventArgs e)
    {
         Navigation.PushModalAsync(new SignUpPage());
    }
}