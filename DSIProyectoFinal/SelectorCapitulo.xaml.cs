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
    public sealed partial class SelectorCapitulo : Page
    {
        public SelectorCapitulo()
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

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            char s = (Char)e.Parameter;
            LevelText.Text = s.ToString();

            //inicializacion provisional
            Zone1.Content = "Page " + s.ToString() + " - 1";
            Zone2.Content = "Page " + s.ToString() + " - 2";
            Zone3.Content = "Page " + s.ToString() + " - 3";
            Zone4.Content = "Page " + s.ToString() + " - 4";
            Zone5.Content = "Page " + s.ToString() + " - 5";

            chapter.Text = "CHAPTER " + s;
            base.OnNavigatedTo(e);
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

        private void PageClick(object sender, RoutedEventArgs e)
        {
            PlayButton.Visibility = Visibility.Visible;
        }
    }
}
