#if WINDOWS_UWP
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;
#else
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml;
#endif

namespace ListViewBaseSelectionRepro
{
    public class CustomListViewBase : ListViewBase
    {
        public CustomListViewBase()
        {
            this.DefaultStyleKey = typeof(CustomListViewBase);
        }

        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
        }
    }
}