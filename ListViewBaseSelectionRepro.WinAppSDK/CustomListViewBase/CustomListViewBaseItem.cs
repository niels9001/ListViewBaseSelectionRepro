#if WINDOWS_UWP
using Windows.UI.Xaml.Controls;
#else
using Microsoft.UI.Xaml.Controls;
#endif

namespace ListViewBaseSelectionRepro
{
    public sealed class CustomListViewBaseItem : ListViewItem
    {
        public CustomListViewBaseItem()
        {
            this.DefaultStyleKey = typeof(CustomListViewBaseItem);
        }

        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
        }
    }
}