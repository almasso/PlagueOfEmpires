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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace PlagueOfEmpires
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainGame : Page
    {
        string Enemy1 = "./Assets/virusA-Morado.png";
        string Enemy2 = "./Assets/virusB-Rojo.png";
        string Player = "./Assets/virusC-Azul.png";

        public ObservableCollection<VMStructure> ListaEstructuras { get; } = new ObservableCollection<VMStructure>();
        public ObservableCollection<VMStructure> EstructurasTablero { get; set; } = new ObservableCollection<VMStructure>();

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

                for(int i = 0; i < 72; i++) {
                    VMStructure tmp = new VMStructure(i);
                    EstructurasTablero.Add(tmp);
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

        private void ImageGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            VMStructure item = e.ClickedItem as VMStructure;
        }

        private async void MiGridView_Drop(object sender, DragEventArgs e)
        {
            var id = await e.DataView.GetTextAsync();
            VMStructure tmp = ListaEstructuras.ElementAt(Int32.Parse(id)) as VMStructure;
            Viewbox vb = e.OriginalSource as Viewbox;
            Grid gr = vb.Child as Grid;
            Image img = gr.Children[0] as Image;
            img.Source = new BitmapImage(new Uri("ms-appx:///" + tmp.Imagen));
        }

        private void GridView_DragItemsStarting(object sender, DragItemsStartingEventArgs e)
        {
            VMStructure item = e.Items[0] as VMStructure;
            e.Data.SetText(item.Id.ToString());
            e.Data.RequestedOperation = Windows.ApplicationModel.DataTransfer.DataPackageOperation.Move;
        }

        private void MiGridView_DragOver(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = Windows.ApplicationModel.DataTransfer.DataPackageOperation.Move;
        }
    }
}
