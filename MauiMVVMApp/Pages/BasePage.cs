﻿namespace MauiMVVMApp.Pages;
public abstract class BasePage<TViewModel> : ContentPage where TViewModel : BaseViewModel
{
    public abstract void Build();

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        Build();
#if DEBUG
        HotReloadService.UpdateApplicationEvent += ReloadUi;
#endif
    }

    protected override void OnNavigatedFrom(NavigatedFromEventArgs args)
    {
        base.OnNavigatedFrom(args);
#if DEBUG
        HotReloadService.UpdateApplicationEvent -= ReloadUi;
#endif
    }

    private void ReloadUi(Type[] obj)
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            Build();
        });
    }
    
    public BasePage(TViewModel vm)
    {
        BindingContext = vm;
    }
}
