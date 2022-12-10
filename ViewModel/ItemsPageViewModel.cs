using CommunityToolkit.Mvvm.ComponentModel;

namespace MyApp.ViewModel
{
    [QueryProperty("Text", "Name")]
    public partial class ItemsPageViewModel : ObservableObject
    {
        [ObservableProperty]
        string text;
    }
}
