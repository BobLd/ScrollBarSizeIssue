using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.ObjectModel;

namespace ScrollBarSizeIssue.ViewModels;

public partial class MainViewModel : ViewModelBase
{

    [ObservableProperty] private ObservableCollection<ItemViewModel> _pages = new();

    private void FillList()
    {
        int i = 0;
        foreach (var animal in new string[]
                 {
                     "cat", "camel", "cow", "chameleon", "mouse", "lion", "zebra", "cow", "chameleon", "mouse", "lion", "zebra", "cow", "chameleon", "mouse", "lion", "zebra", "cow", "chameleon", "mouse", "lion", "zebra", "cow", "chameleon", "mouse", "lion", "zebra", "cow", "chameleon", "mouse", "lion", "zebra", "cow", "chameleon", "mouse", "lion", "zebra",
                     "cat", "camel", "cow", "chameleon", "mouse", "lion", "zebra", "cow", "chameleon", "mouse", "lion", "zebra", "cow", "chameleon", "mouse", "lion", "zebra", "cow", "chameleon", "mouse", "lion", "zebra", "cow", "chameleon", "mouse", "lion", "zebra", "cow", "chameleon", "mouse", "lion", "zebra", "cow", "chameleon", "mouse", "lion", "zebra",
                     "cat", "camel", "cow", "chameleon", "mouse", "lion", "zebra", "cow", "chameleon", "mouse", "lion", "zebra", "cow", "chameleon", "mouse", "lion", "zebra", "cow", "chameleon", "mouse", "lion", "zebra", "cow", "chameleon", "mouse", "lion", "zebra", "cow", "chameleon", "mouse", "lion", "zebra", "cow", "chameleon", "mouse", "lion", "zebra"
                 })
        {
            Pages.Add(new ItemViewModel()
            {
                Number = i++,
                Text = animal
            });
        }
    }

    public MainViewModel()
    {
        FillList();
    }
}
