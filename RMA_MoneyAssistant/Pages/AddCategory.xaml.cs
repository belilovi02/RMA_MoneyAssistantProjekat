using RMA_MoneyAssistant.Helpers;
namespace RMA_MoneyAssistant.Pages;

public partial class AddCategory : ContentPage
{
    public AddCategory()
	{

        InitializeComponent();
    }

    private async void Done(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
