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
    public sealed partial class MainMenu : Page
    {
        public MainMenu()
        {
            this.InitializeComponent();
        }

        private void TextBlock_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (((Frame)Window.Current.Content).ActualHeight > 600 && ((Frame)Window.Current.Content).ActualWidth > 600)
                (sender as TextBlock).FontSize = 80;
            else
                (sender as TextBlock).FontSize = 40;
        }

        private void GoToTeams(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(TeamSelect));
        }

        private void GoToKnights(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Abilities));
        }

        private void GoToSettings(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Opciones));
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void GoToPvp(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PVP));
        }

        private void GoToStore(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Store));
        }

        private void GoToModoHistoria(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ModoHistoria));
        }
    }
}
