using System;
using System.Collections.Generic;
using System.ComponentModel;
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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace PlagueOfEmpires
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class OptionsMusic : Page, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        bool goBackToMainMenu = false;
        string MusicIcon = "Volume";
        string SoundsIcon = "Volume";
        string VolumeIcon = "Volume";
        string NotificationsIcon = "Volume";
        string MusicValue = "100%";
        string SoundsValue = "100%";
        string VolumeValue = "100%";
        string NotificationsValue = "100%";
        public OptionsMusic()
        {
            this.InitializeComponent();
        }

        private void VolumeSlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            string msg = string.Format("{0}%", e.NewValue);
            VolumeValue = msg;
            if (e.NewValue == 0) VolumeIcon = "Mute";
            else VolumeIcon = "Volume";
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(VolumeValue)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(VolumeIcon)));
        }

        private void MusicSlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            string msg = string.Format("{0}%", e.NewValue);
            MusicValue = msg;
            if (e.NewValue == 0) MusicIcon = "Mute";
            else MusicIcon = "Volume";
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MusicValue)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MusicIcon)));
        }

        private void SoundsSlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            string msg = string.Format("{0}%", e.NewValue);
            SoundsValue = msg;
            if (e.NewValue == 0) SoundsIcon = "Mute";
            else SoundsIcon = "Volume";
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SoundsValue)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SoundsIcon)));
        }

        private void NotificationsSlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            string msg = string.Format("{0}%", e.NewValue);
            NotificationsValue = msg;
            if (e.NewValue == 0) NotificationsIcon = "Mute";
            else NotificationsIcon = "Volume";
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NotificationsValue)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NotificationsIcon)));
        }
    }
}
