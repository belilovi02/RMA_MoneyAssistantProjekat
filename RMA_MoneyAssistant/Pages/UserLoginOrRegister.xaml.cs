namespace RMA_MoneyAssistant.Pages;

public partial class UserLoginOrRegister : ContentPage
{
	public UserLoginOrRegister()
	{
		InitializeComponent();
	}
    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Login");
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Register");
    }
}