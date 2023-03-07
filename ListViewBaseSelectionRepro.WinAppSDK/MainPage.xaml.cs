#if WINDOWS_UWP
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
#else
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
#endif
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ListViewBaseSelectionRepro;

public sealed partial class MainPage : Page
{
    ObservableCollection<CustomListViewBaseItem> itemsCollection;
    public MainPage()
    {
        this.InitializeComponent();

        itemsCollection = new ObservableCollection<CustomListViewBaseItem>
        {
            new CustomListViewBaseItem() { Content = "Item 1" },
            new CustomListViewBaseItem() { Content = "Item 2" },
            new CustomListViewBaseItem() { Content = "Item 3" },
            new CustomListViewBaseItem() { Content = "Item 4" }
        };
    }
}
