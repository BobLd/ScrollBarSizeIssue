using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Templates;
using Avalonia.Input;

namespace ScrollBarSizeIssue.Views;

public class TestItemsControl : ItemsControl
{
    private static readonly FuncTemplate<Panel?> DefaultPanel = new(() => new VirtualizingStackPanel());


    static TestItemsControl()
    {
        ItemsPanelProperty.OverrideDefaultValue<TestItemsControl>(DefaultPanel);
    }

    protected override Control CreateContainerForItemOverride(object? item, int index, object? recycleKey)
    {
        return new TestItem();
    }

    protected override bool NeedsContainerOverride(object? item, int index, out object? recycleKey)
    {
        return NeedsContainer<TestItem>(item, out recycleKey);
    }
}