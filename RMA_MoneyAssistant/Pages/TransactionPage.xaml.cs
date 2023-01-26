namespace RMA_MoneyAssistant.Pages;

public partial class TransactionPage : ContentPage
{
	public TransactionPage()
	{
		InitializeComponent();
	}
    private async void AddTransactionClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new AddTransaction());
    }
    private async void AddCategoryClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new AddCategory());
    }
}