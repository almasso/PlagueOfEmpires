using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Globalization;
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
    public sealed partial class OptionsLanguaje : Page
    {
        string selectedLanguage;
        bool spanish;
        bool english;
        bool german;

        public OptionsLanguaje()
        {
            this.InitializeComponent();
            selectedLanguage = ApplicationLanguages.PrimaryLanguageOverride;

            switch(selectedLanguage)
            {
                case "es-ES":
                {
                    spanish = true;
                    english = false;
                    german = false;
                    break;
                }
                case "en-US":
                {
                    spanish = false;
                    english = true;
                    german = false;
                    break;
                }
                case "de-DE":
                {
                    spanish = false;
                    english = false;
                    german = true;
                    break;
                }
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string language = (e.AddedItems[0] as ComboBoxItem).Content as string;
            language.ToUpper();
            string langTMP = " ";

            switch (language)
            {
                case "ESPAÑOL": langTMP = "es-ES"; break;
                case "ENGLISH": langTMP = "en-US"; break;
                case "DEUTSCH": langTMP = "de-DE"; break;
            }

            ApplicationLanguages.PrimaryLanguageOverride = langTMP;

            Frame.Navigate(this.GetType());
        }
    }
}
