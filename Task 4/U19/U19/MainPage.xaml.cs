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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace U19
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(BlankPage1));
        }
        private void HomeButton_Click(Object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(BlankPage1));
        }
        private void BackButton_Click(Object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
        {
                MyFrame.GoBack();
            }
        }
            
        private void ForwarButton_Click(Object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoForward)
            {
                MyFrame.GoForward();
            }
        }
        private void NavagateButton_Click(Object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage1));
        }
       
    }
}
