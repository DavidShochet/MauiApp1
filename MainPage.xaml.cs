namespace MauiApp1;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageModel pageModel)
	{
		InitializeComponent();
        BindingContext = pageModel;
    }
}

