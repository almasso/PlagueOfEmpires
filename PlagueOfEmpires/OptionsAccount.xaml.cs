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
    public sealed partial class OptionsAccount : Page
    {
        public OptionsAccount()
        {
            this.InitializeComponent();
        }

        private void ButtonMusic_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(OptionsMenu));
        }

        private void ButtonGraphics_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(OptionsGraphics));
        }

        private void ButtonLanguaje_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(OptionsLanguaje));
        }

        private void ButtonControls_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(OptionsControls));
        }

        private void BackButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
