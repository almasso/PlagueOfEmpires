﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace PlagueOfEmpires
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    
    public sealed partial class MainPage : Page
    {
        Controlador gameController;
        public MainPage()
        {
            this.InitializeComponent();
            gameController = new Controlador(this);
        }

        private void Singleplayer_Button(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Singleplayer));
        }

        private void Multiplayer_Button(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Multiplayer));
        }

        private void DLC_Button(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AdditionalContent));
	    }

        private void Options_OnClick(object sender, RoutedEventArgs e)
        {
            // The Page.Frame property is a reference to the Frame that's displaying the page.
            // Use Frame.Navigate to go to the next page.
            Frame.Navigate(typeof(OptionsMenu), true);
        }

        public void ActualizaIU() { }

        
    }
}
