using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.Media.Core;
using Windows.Media.Playback;

namespace PlagueOfEmpires
{
    internal class Sound
    {

        public MediaPlayer player;
        public static async void PlayButtonSound(string filename)
        {
            Windows.Storage.StorageFolder folder = await Package.Current.InstalledLocation.GetFolderAsync(@"Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync(filename);
            player.AutoPlay = false;
            player.Source = MediaSource.CreateFromStorageFile(file);
            player.Play();
        }
    }
}
