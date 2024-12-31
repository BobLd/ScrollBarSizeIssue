using CommunityToolkit.Mvvm.ComponentModel;

namespace ScrollBarSizeIssue.ViewModels
{
    public partial class ItemViewModel : ViewModelBase
    {
        [ObservableProperty] private string _text;

        [ObservableProperty] private int _number;
    }
}