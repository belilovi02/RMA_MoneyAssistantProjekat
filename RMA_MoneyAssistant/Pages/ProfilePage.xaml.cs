using RMA_MoneyAssistant.Helpers;
namespace RMA_MoneyAssistant.Pages;

public partial class ProfilePage : ContentPage
{

    public ProfilePage()
	{
        InitializeComponent();

        User _user = new User();
        _user.UserName = username.Text;
        _user.Email = email.Text;
        _user.PhoneNumber = phonenumber.Text;

    }

}