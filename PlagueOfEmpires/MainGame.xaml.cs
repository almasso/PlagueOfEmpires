using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Numerics;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace PlagueOfEmpires
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainGame : Page
    {
        string Enemy1 = "./Assets/Virus1.png";
        string Enemy2 = "./Assets/Virus2.png";
        string Player = "./Assets/Virus3.png";

        public ObservableCollection<VMStructure> ListaEstructuras { get; } = new ObservableCollection<VMStructure>();

        public MainGame()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e?.Parameter is string[] a)
            {
                Enemy1 = a[0];
                Player = a[1];
                Enemy2 = a[2];
            }
            if (ListaEstructuras != null)
            {
                foreach (Structure m in StructureModel.GetAllStructures())
                {
                    VMStructure tmp = new VMStructure(m);
                    ListaEstructuras.Add(tmp);
                }
            }
            base.OnNavigatedTo(e);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PauseMenu));
        }

        private void GridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
