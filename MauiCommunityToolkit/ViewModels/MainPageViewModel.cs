using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiCommunityToolkit.ViewModels;


public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty] private int _count = 0;
    [ObservableProperty] private string _text = "Click me";

    [RelayCommand]
    void CounterClicked()
    {
        Count++;

        Text = Count == 1 
            ? $"Clicked {Count} time" 
            : $"Clicked {Count} times";

        SemanticScreenReader.Announce(Text);
    }
}