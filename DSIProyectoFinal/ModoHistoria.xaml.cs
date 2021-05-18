using System;
using System.Collections.Generic;
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

namespace DSIProyectoFinal
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class ModoHistoria : Page
    {
        public ModoHistoria()
        {
            this.InitializeComponent();
        }
        private void GoBack(object sender, RoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
            }
        }

        private void GoToPlay(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Defensa));
        }

        private void GoToMainMenu(object sender, RoutedEventArgs e)
        {
            while (this.Frame.CanGoBack)
                Frame.GoBack();
        }

        private void GoToSettings(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Opciones));
        }


        private void ChangeToChapterSelection(object sender, ItemClickEventArgs e)
        {
            //Image b = e.OriginalSource as Image;
            //string s = b.Name;
            //Frame.Navigate(typeof(SelectorCapitulo), s[5]);
        }

        private void Grid_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Escape)
            {
                if (this.Frame.CanGoBack)
                {
                    this.Frame.GoBack();
                }
            }
        }
    }
}
