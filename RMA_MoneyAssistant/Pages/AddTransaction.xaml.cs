
using RMA_MoneyAssistant.Helpers;
namespace RMA_MoneyAssistant.Pages;

public partial class AddTransaction : ContentPage
{
    public List<Category> categoryList { get; set; }
    public List<TypeOfTransaction> transactionList { get; set; }
    public AddTransaction()
	{
        categoryList = new List<Category>
        {
            new Category{Id=1, Name="Food"},
            new Category{Id=2, Name="Regres"},
            new Category{Id=3, Name="Salary"},
            new Category{Id=4, Name="Clothes"}
        };

        transactionList = new List<TypeOfTransaction>
        {
            new TypeOfTransaction{Id=1, Name="Income"},
            new TypeOfTransaction{Id=2, Name="Expense"}
        };

        InitializeComponent();

        BindingContext = this;

        category.ItemsSource = categoryList;
        typeOfTransaction.ItemsSource = transactionList;
    }

    private async void Done(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}