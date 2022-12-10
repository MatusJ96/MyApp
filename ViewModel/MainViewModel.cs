using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MyApp.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {

        [ObservableProperty]
        ObservableCollection<string> items;

        public MainViewModel()
        {
            Items = new ObservableCollection<string>();
        }

        [ObservableProperty]
        string text;

        [RelayCommand]
        void Add()
        {
            if (string.IsNullOrWhiteSpace(Text)) { return; }
            Items.Add(Text);
            Text = string.Empty;
        }

        [RelayCommand]
        void Delete(string s)
        {
            if (Items.Contains(s))
            {
                Items.Remove(s);
            }
        }

        [RelayCommand]
        async Task Save(string s)
        {
            await Shell.Current.GoToAsync($"{nameof(ItemsPage)}?Name={s}");
        }
    }
}



//    public string Text
//    {
//        get => text;
//        set
//        {
//            text = value;
//            OnPropertyChagned(nameof(Text));
//        } 
//    }

//    public event PropertyChangedEventHandler PropertyChanged;
//    void OnPropertyChagned(string name)=>
//        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));