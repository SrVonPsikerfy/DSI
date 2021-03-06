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
using Windows.UI.Xaml.Controls;
using Windows.Storage;

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

       
        private void GoToTeams(object sender, RoutedEventArgs e)
        {
            Sounds.playSound("button.wav");
            this.Frame.Navigate(typeof(TeamConfig));
        }

        private void GoToKnights(object sender, RoutedEventArgs e)
        {
            Sounds.playSound("button.wav");
            this.Frame.Navigate(typeof(Abilities));
        }

        private void GoToSettings(object sender, RoutedEventArgs e)
        {
            Sounds.playSound("button.wav");
            this.Frame.Navigate(typeof(Opciones));
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Sounds.playSound("button.wav");
            Application.Current.Exit();
        }

        private void GoToPvp(object sender, RoutedEventArgs e)
        {
            Sounds.playSound("button.wav");
            this.Frame.Navigate(typeof(PVP));
        }

        private void GoToStore(object sender, RoutedEventArgs e)
        {
            Sounds.playSound("button.wav");
            this.Frame.Navigate(typeof(Store));
        }

        private void GoToModoHistoria(object sender, RoutedEventArgs e)
        {
            Sounds.playSound("button.wav");
            this.Frame.Navigate(typeof(ModoHistoria));
        }
    }
}
