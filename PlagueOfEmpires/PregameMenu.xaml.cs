using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class PregameMenu : Page, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        string Porcentaje = "50%";
        bool isRandom = true;
        public PregameMenu()
        {
            this.InitializeComponent();
        }

        private void BackButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }
        }

        private void PlayButton_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainGame));
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Slider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            string msg = string.Format("{0}%", e.NewValue);
            Porcentaje = msg;
            PropertyChanged?.Invoke( this, new PropertyChangedEventArgs(nameof(Porcentaje)));
        }

        private void MapCheckBox_OnChecked(object sender, RoutedEventArgs e)
        {
            isRandom = false;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(isRandom)));
        }

        private void MapCheckBox_OnUnchecked(object sender, RoutedEventArgs e)
        {
            isRandom = true;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(isRandom)));
        }

        private void RadioButtonA_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButtonB_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButtonC_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButtonD_Checked(object sender, RoutedEventArgs e)
        {

        }

        private async void SavePresetButton_Click(object sender, RoutedEventArgs e)
        {
            var messageDialog = new MessageDialog("Preset saved");
            await messageDialog.ShowAsync();
        }

        private async void LoadPresetButton_Click(object sender, RoutedEventArgs e)
        {
            var messageDialog = new MessageDialog("You have no presets available to load");
            await messageDialog.ShowAsync();
        }
    }
}
