#if WINDOWS_UWP
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;
#else
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml;
#endif
using System.Diagnostics;

namespace ListViewBaseSelectionRepro
{
    public class CustomListViewBase : ListViewBase
    {
        int CustomSelectedIndex = -1;
        public CustomListViewBase()
        {
            this.DefaultStyleKey = typeof(CustomListViewBase);
            Debug.WriteLine("Constructor: " + SelectedIndex);
            RegisterPropertyChangedCallback(SelectedIndexProperty, OnSelectionIndexChanged);
        }

        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            Debug.WriteLine("OnApplyTemplate: " + SelectedIndex);

            // Uncomment to make it work
            // SelectedIndex = (int)CustomSelectedIndex;
        }

        private void OnSelectionIndexChanged(DependencyObject sender, DependencyProperty dp)
        {
            if (CustomSelectedIndex == -1 && SelectedIndex > -1)
            {
                CustomSelectedIndex = SelectedIndex;
            }
            Debug.WriteLine("OnSelectionIndexChanged: " + SelectedIndex);
        }
    }
}