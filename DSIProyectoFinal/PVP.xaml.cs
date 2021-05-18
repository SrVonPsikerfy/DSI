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
using Windows.UI.Xaml.Media.Imaging;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace DSIProyectoFinal
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class PVP : Page
    {
        bool isAtacking = false;
        public PVP()
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

        private void DefendClick(object sender, RoutedEventArgs e)
        {
            rectangleModeSelection.Fill = (SolidColorBrush)Resources["GreenColor"];
            defenseImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/defensorSelectedIcon.png"));
            attackImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/atacanteIcon.png"));
            isAtacking = false;
        }

        private void AttackClick(object sender, RoutedEventArgs e)
        {
            rectangleModeSelection.Fill = (SolidColorBrush)Resources["RedColor"];
            attackImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/atacanteSelectedIcon.png"));
            defenseImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/defensorIcon.png"));
            isAtacking = true;
        }

        private void EnterClick(object sender, RoutedEventArgs e)
        {
            if(isAtacking) this.Frame.Navigate(typeof(Ataque));
            else this.Frame.Navigate(typeof(Defensa));
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
