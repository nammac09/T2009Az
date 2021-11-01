using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Net.Cache;
using Music_Store.models;
using System.Windows;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Music_Store
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<sound> Sounds;
        private bool istart = false;
        private bool isRepeat = false;
        private string soundSouce = "";
        public MainPage()
        {
            this.InitializeComponent();
            Sounds = new ObservableCollection<sound>();
            soundmanager.GetAllSounds(Sounds);
        }
        
        private void Search_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {

        }

        private void SoundGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var sound = (sound)e.ClickedItem;
            Nhaccuatui.Source = new Uri(this.BaseUri, sound.audioFile);
            ResultName.Text = sound.Name;
            soundSouce = sound.audioFile;
            istart = true;
            imgSound.Content = "||";
            MyProgressbar.Maximum = Nhaccuatui.NaturalDuration.TimeSpan.TotalSeconds;
        }

        private void MyProgressbar_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            if (soundSouce == "")
            {
                return;
            }
            TimeSpan newPlayTime = new TimeSpan(0, 0, 0, 0, (int)MyProgressbar.Value);
            Nhaccuatui.Position = newPlayTime;
        }

        private void Nhaccuatui_MediaOpened(object sender, RoutedEventArgs e)
        {
            imgSound.Content = "||";
        }

        private void imgSound_Click(object sender, RoutedEventArgs e)
        {
            if(soundSouce == "")
            {
                return;
            }
            if (!istart)
            {
                imgSound.Content = "||";
                istart = true;
                Nhaccuatui.Play();
            }
            else
            {
                imgSound.Content = "►";
                istart = false;
                Nhaccuatui.Pause();
            }
        }

        private void Nhaccuatui_MediaEnded(object sender, RoutedEventArgs e)
        {
            imgSound.Content = "►";
            if (isRepeat)
            {
                Nhaccuatui.Play();
            }
        }

        private void CheckBox_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (MyCheckBox.IsChecked.ToString() == "true")
            {
                isRepeat = true;
            }
            else
            {
                isRepeat = false;
            }
        }
    }
}
