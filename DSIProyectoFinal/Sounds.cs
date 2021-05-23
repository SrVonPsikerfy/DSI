using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.Storage;

namespace DSIProyectoFinal
{
    class Sounds
    {
        static public async void playSound(string name)
        {
            MediaElement PlayMusic = new MediaElement();
            StorageFolder Folder = Windows.ApplicationModel.Package.Current.InstalledLocation;
            Folder = await Folder.GetFolderAsync(@"Assets\Sounds");
            StorageFile sf = await Folder.GetFileAsync(name);
            PlayMusic.SetSource(await sf.OpenAsync(FileAccessMode.Read), sf.ContentType);
            PlayMusic.Play();
        }
    }
}
