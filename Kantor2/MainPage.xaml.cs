using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Kantor2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void home_click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            this.Frame.Navigate(typeof(Pages.home));
        }

        private void history_click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            this.Frame.Navigate(typeof(Pages.history));
        }

        private void home_tapped(object sender, TappedRoutedEventArgs e)
        {
            TextBlock b = (TextBlock)sender;
            this.Frame.Navigate(typeof(Pages.home));
        }

        private void history_tapped(object sender, TappedRoutedEventArgs e)
        {
            TextBlock b = (TextBlock)sender;
            this.Frame.Navigate(typeof(Pages.history));

        }
        
        }
}
