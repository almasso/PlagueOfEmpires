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
    public sealed partial class OptionsAccount : Page, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        string SignUpButton = "SIGN UP";
        string SignInButton = "SIGN IN";
        string SignInText = "SIGN IN";
        string AccountText = "DON'T HAVE AN ACCOUNT?";
        bool goBackToMainMenu = false;
        public OptionsAccount()
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

        private void ButtonControls_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(OptionsControls), goBackToMainMenu);
        }

        private void BackButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                if (goBackToMainMenu) Frame.Navigate(typeof(MainPage));
                else Frame.Navigate(typeof(PauseMenu));
            }
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            if(SignUpButtonName.Content.ToString() == "SIGN UP")
            {
                SignUpButton = "SIGN IN";
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SignUpButton)));
                SignInButton = "SIGN UP";
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SignInButton)));
                SignInText = "SIGN UP";
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SignInText)));
                AccountText = "ALREADY HAVE AN ACCOUNT?";
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AccountText)));
            }
            else
            {
                SignUpButton = "SIGN UP";
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SignUpButton)));
                SignInButton = "SIGN IN";
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SignInButton)));
                SignInText = "SIGN IN";
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SignInText)));
                AccountText = "DON'T HAVE AN ACCOUNT?";
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AccountText)));
            }
        }

        private void ButtonCredits_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(OptionsCredits), goBackToMainMenu);
        }
    }
}
