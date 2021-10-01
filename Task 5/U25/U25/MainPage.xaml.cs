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

namespace U25
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

        private void MyCalendarView_SelectedDatesChanged(CalendarView sender, CalendarViewSelectedDatesChangedEventArgs args)
        {
            var selectedDates = sender.SelectedDates.Select(p => p.Date.Month.ToString() + "/" + p.Date.Day.ToString()).ToArray();
            var values = string.Join(",", selectedDates);
            CalendarViewResultTextBlock.Text = values;
        }

        private void InnerFlyoutButton_Click(object sender, RoutedEventArgs e)
        {
            MyFlyout.Hide();
        }
        private string[] selectItem = new string[]
            {"a","b","c","d"};
        private void MyAutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            var autosuggestnox = (AutoSuggestBox)sender;
            var filted = selectItem.Where(p => p.StartsWith(autosuggestnox.Text)).ToArray();
            autosuggestnox.ItemsSource = filted;
        }
        private void AutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            var autosuggestnox = (AutoSuggestBox)sender;
            var filted = selectItem.Where(p => p.StartsWith(autosuggestnox.Text)).ToArray();
            autosuggestnox.ItemsSource = filted;
        }
    }
}
