using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace PlagueOfEmpires
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdditionalContent : Page, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<VMMod> ListaMods { get; } = new ObservableCollection<VMMod>();

        Sound sonido;

        public AdditionalContent()
        {
            this.InitializeComponent();
            sonido = new Sound();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if(ListaMods != null)
            {
                foreach(Mod m in ModModel.GetAllMods())
                {
                    VMMod tmp = new VMMod(m);
                    ListaMods.Add(tmp);
                }
            }
            base.OnNavigatedTo(e);
        }

        private void ReturnWithEscape(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Escape)
            {
                if (Frame.CanGoBack) Frame.GoBack();
            }
        }

        private void ReturnWithLeftClick(object sender, PointerRoutedEventArgs e)
        {
            foreach (object b in BotonesPrincipales.Children)
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

        private void Activate(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            b.SetValue(IsEnabledProperty, false);
            var tmp = b.Parent as StackPanel;
            Button but2 = tmp.Children[1] as Button;
            but2.SetValue(IsEnabledProperty, true);
            var gridPrincipal = ((tmp.Parent as StackPanel).Parent as Grid).Parent as Grid;
            Ellipse el = gridPrincipal.Children[1] as Ellipse;
            el.Fill = VMMod.GetSolidColorBrush("#FF92d36e");
            el.Stroke = VMMod.GetSolidColorBrush("#FF243e16");
            SymbolIcon sym = gridPrincipal.Children[2] as SymbolIcon;
            sym.Symbol = Symbol.Accept;

            var item = b.DataContext;
            int index = MiListView.Items.IndexOf(item);
            Mod m = ModModel.GetModById(index);
            m.Activado = true;
            sonido.PlayButtonSound();
        }

        private void Deactivate(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            b.SetValue(IsEnabledProperty, false);
            var tmp = b.Parent as StackPanel;
            Button but2 = tmp.Children[0] as Button;
            but2.SetValue(IsEnabledProperty, true);
            var gridPrincipal = ((tmp.Parent as StackPanel).Parent as Grid).Parent as Grid;
            Ellipse el = gridPrincipal.Children[1] as Ellipse;
            el.Fill = VMMod.GetSolidColorBrush("#FFff5d55");
            el.Stroke = VMMod.GetSolidColorBrush("#FF5e0202");
            SymbolIcon sym = gridPrincipal.Children[2] as SymbolIcon;
            sym.Symbol = Symbol.Cancel;

            var item = b.DataContext;
            int index = MiListView.Items.IndexOf(item);
            Mod m = ModModel.GetModById(index);
            m.Activado = false;
            sonido.PlayButtonSound();
        }
    }
}
