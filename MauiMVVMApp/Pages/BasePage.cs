namespace MauiMVVMApp.Pages;
public class BasePage<TViewModel> : ContentPage where TViewModel : BaseViewModel
{
    public BasePage(TViewModel vm)
    {
        BindingContext = vm;
    }
}
