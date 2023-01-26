using RMA_MoneyAssistant.Helpers;
namespace RMA_MoneyAssistant.Pages;

public partial class AddCategory : ContentPage
{
    public List<Category> categoryList { get; set; }
    public AddCategory()
	{
        categoryList = new List<Category>
        {
            new Category{Id=1, Name="Food"},
            new Category{Id=2, Name="Regres"},
            new Category{Id=3, Name="Salary"},
            new Category{Id=4, Name="Clothes"}
        };

        InitializeComponent();

        BindingContext = this;

        category.ItemsSource = categoryList;
    }
}