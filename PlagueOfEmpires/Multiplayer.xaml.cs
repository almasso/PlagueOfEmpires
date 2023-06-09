﻿using System;
using System.Collections.Generic;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace PlagueOfEmpires
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Multiplayer : Page
    {
        Sound sonido;

        public Multiplayer()
        {
            this.InitializeComponent();
            sonido = new Sound();
        }

        private void ReturnWithEscape(object sender, KeyRoutedEventArgs e)
        {
            if(e.Key == Windows.System.VirtualKey.Escape)
            {
                if (Frame.CanGoBack) Frame.GoBack();
            }
        }

        private void ReturnWithLeftClick(object sender, PointerRoutedEventArgs e)
        {
            foreach(object b in BotonesPrincipales.Children)
            {
                if (b is Button)
                {
                    Button but = b as Button;
                    if (but.IsEnabled)
                    {
                        if (e.GetCurrentPoint(but).Properties.IsLeftButtonPressed)
                        {
                            if (Frame.CanGoBack) Frame.GoBack();
                        }
                    }
                }
                
            } 
        }

        private async void LocalButton_Click(object sender, RoutedEventArgs e)
        {
            sonido.PlayButtonSound();
            var messageDialog = new MessageDialog("We couldn't find another player.\nPlease try again later.");
            await messageDialog.ShowAsync();
        }

        private async void OnlineButton_Click(object sender, RoutedEventArgs e)
        {
            sonido.PlayButtonSound();
            var messageDialog = new MessageDialog("We couldn't find an available match.\nPlease try again later.");
            await messageDialog.ShowAsync();
        }
    }
}
