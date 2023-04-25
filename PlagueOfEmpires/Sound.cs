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
        public MediaPlayer music;
        public bool isPlaying_;

        public Sound() {
            player = new MediaPlayer();
            music = new MediaPlayer();
        }
        public async void PlayButtonSound()
        {
            Windows.Storage.StorageFolder folder = await Package.Current.InstalledLocation.GetFolderAsync(@"Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Button.wav");
            player.AutoPlay = false;
            player.Source = MediaSource.CreateFromStorageFile(file);
            player.Play();
        }

        public async void PlayMusic()
        {
            Windows.Storage.StorageFolder folder = await Package.Current.InstalledLocation.GetFolderAsync(@"Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("backgroundmusic.wav");
            music.AutoPlay = true;
            music.Source = MediaSource.CreateFromStorageFile(file);
            music.IsLoopingEnabled = true;
            music.Volume = 0.1f;
            music.Play();
        }
    }
}
