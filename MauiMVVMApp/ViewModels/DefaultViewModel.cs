namespace MauiMVVMApp.ViewModels;
public partial class DefaultViewModel : BaseViewModel
{
    [ObservableProperty]
    string title = "Welcome to MVVM!";

    [ObservableProperty]
    string submissionText = string.Empty;

    public string Placeholder { get; init; } = "Press enter to change title.";
    public DefaultViewModel()
    {

    }

    [RelayCommand]
    public void SetTitle()
        {
        if (SubmissionText == string.Empty)
        {
            return;
        }

        Title = SubmissionText;
        SubmissionText = string.Empty;
    }
}
