namespace MauiMVVMApp;
public class AppShell : Shell
{
    public AppShell(DefaultPage defaultPage)
    {
        Items.Add(defaultPage);
        Routing.RegisterRoute(nameof(DefaultPage), typeof(DefaultPage));
    }
}
