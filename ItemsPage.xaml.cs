using MyApp.ViewModel;

namespace MyApp;

public partial class ItemsPage : ContentPage
{
	public ItemsPage(ItemsPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext= viewModel;
	}
}