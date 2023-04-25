﻿using System;
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
    public sealed partial class PauseMenu : Page
    {
        Sound sonido;

        public PauseMenu()
        {
            this.InitializeComponent();
            sonido = new Sound();
        }

        private void BackButton_OnClick(object sender, RoutedEventArgs e)
        {
            sonido.PlayButtonSound();
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            sonido.PlayButtonSound();
            Frame.Navigate(typeof(MainPage));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            sonido.PlayButtonSound();
            Frame.Navigate(typeof(OptionsMenu));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            sonido.PlayButtonSound();
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }
        }
    }
}
