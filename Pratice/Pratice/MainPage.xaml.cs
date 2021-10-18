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

namespace Pratice
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Icon> Icons;
        private ObservableCollection<Item> items;
        public MainPage()
        {
            Icons = new List<Icon>();
            Icons.Add(new Icon { IconPath = "Assets/1.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/2.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/3.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/4.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/5.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/6.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/7.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/8.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/9.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/10.jpg" });

            items = new ObservableCollection<Item>();
            items.Add(new Item { Pruduct = "Meo", Description = "Hi hi", ImgPath = "Assets/5.jpg" });
            this.InitializeComponent();
        }

        private void OrderButton_Click(object sender, RoutedEventArgs e)
        {
            string imgpath = ((Icon)MyCombobox.SelectedValue).IconPath;
            items.Add(new Item { Pruduct = ProductReults.Text, Description = DescriptionReults.Text, ImgPath = imgpath });

            ProductReults.Text = "";
            DescriptionReults.Text = "";
            MyCombobox.SelectedIndex = -1;

            ProductReults.Focus(FocusState.Programmatic);


        }
    }
}