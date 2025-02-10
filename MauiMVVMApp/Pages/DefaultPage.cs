namespace MauiMVVMApp.Pages;
public class DefaultPage : BasePage<DefaultViewModel>
{
    public DefaultPage(DefaultViewModel vm) : base(vm)
    {

    }

    public override void Build()
    {
        this.Bind(ContentPage.TitleProperty, getter: (DefaultViewModel vm) => vm.Title);

        Content = new VerticalStackLayout()
        {
            new Entry()
               .Bind(Entry.TextProperty, mode:BindingMode.TwoWay,
                           getter: (DefaultViewModel vm) => vm.SubmissionText,
                           setter: (DefaultViewModel vm, string? submissionText) => vm.SubmissionText = submissionText ?? string.Empty)
               .Bind(Entry.ReturnCommandProperty,
                           getter: (DefaultViewModel vm) => vm.SetTitleCommand)
               .Bind(Entry.PlaceholderProperty, getter: (DefaultViewModel vm) => vm.Placeholder),

                        new Entry()
               .Bind(Entry.TextProperty, mode:BindingMode.TwoWay,
                           getter: (DefaultViewModel vm) => vm.SubmissionText,
                           setter: (DefaultViewModel vm, string? submissionText) => vm.SubmissionText = submissionText ?? string.Empty)
               .Bind(Entry.ReturnCommandProperty,
                           getter: (DefaultViewModel vm) => vm.SetTitleCommand)
               .Bind(Entry.PlaceholderProperty, getter: (DefaultViewModel vm) => vm.Placeholder)
        };
    }
}
