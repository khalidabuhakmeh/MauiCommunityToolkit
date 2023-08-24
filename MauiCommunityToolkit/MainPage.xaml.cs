using MauiCommunityToolkit.ViewModels;

namespace MauiCommunityToolkit;

public partial class MainPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainPageViewModel();
    }
}