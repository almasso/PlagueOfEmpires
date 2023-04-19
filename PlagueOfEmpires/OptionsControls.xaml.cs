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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace PlagueOfEmpires
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class OptionsControls : Page
    {
        bool goBackToMainMenu = false;
        public OptionsControls()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e?.Parameter is bool a)
            {
                goBackToMainMenu = a;
            }
            base.OnNavigatedTo(e);
        }

        private void ButtonMusic_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(OptionsMenu), goBackToMainMenu);
        }

        private void ButtonGraphics_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(OptionsGraphics), goBackToMainMenu);
        }

        private void ButtonLanguaje_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(OptionsLanguaje), goBackToMainMenu);
        }

        private void ButtonAccount_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(OptionsAccount), goBackToMainMenu);
        }

        private void BackButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                if (goBackToMainMenu) Frame.Navigate(typeof(MainPage));
                else Frame.Navigate(typeof(PauseMenu));
            }
        }
    }
}
