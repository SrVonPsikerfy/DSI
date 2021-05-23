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

        public List<Chapter> Chpt = new List<Chapter>() {
            new Chapter('1'),
            new Chapter('2'),
            new Chapter('3'),
            new Chapter('4'),
            new Chapter('5'),
            new Chapter('6'),
            new Chapter('7'),
            new Chapter('8'),
            new Chapter('9'),
        };

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
            Sounds.playSound("button.wav");
            this.Frame.Navigate(typeof(TeamSelect));
        }

        private void GoToMainMenu(object sender, RoutedEventArgs e)
        {
            Sounds.playSound("button.wav");
            while (this.Frame.CanGoBack)
                Frame.GoBack();
        }

        private void GoToSettings(object sender, RoutedEventArgs e)
        {
            Sounds.playSound("button.wav");
            Frame.Navigate(typeof(Opciones));
        }

        private void ChangeToChapterSelection(object sender, ItemClickEventArgs e)
        {
            Sounds.playSound("button.wav");
            Frame.Navigate(typeof(SelectorCapitulo), ((Chapter)e.ClickedItem).numChapter);
        }

        private void Grid_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Sounds.playSound("button.wav");
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
