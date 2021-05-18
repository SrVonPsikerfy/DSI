using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Input;
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

    public sealed partial class Ataque : Page
    {


        private string nameCart;
        bool clicked = false;

        private ContentControl carta;
        public Ataque()
        {
            this.InitializeComponent();
        }

        private void TextBlock_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (((Frame)Window.Current.Content).ActualHeight > 540 && ((Frame)Window.Current.Content).ActualWidth > 960)
                (sender as TextBlock).FontSize = 100;
            else
                (sender as TextBlock).FontSize = 40;
        }

        private void GoToPause(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pause));
        }

        private void Grid_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.OriginalKey != Windows.System.VirtualKey.GamepadB && e.Key == Windows.System.VirtualKey.Escape || e.Key == Windows.System.VirtualKey.GamepadMenu)
            {
                if (this.Frame.CanGoBack)
                {
                    this.Frame.Navigate(typeof(Pause));
                }
            }
        }

        private void MovingCard(object sender, PointerRoutedEventArgs e)
        {
            //Si estoy pulsando una carta distinta...
            if (nameCart != (sender as ContentControl).Name)
            {
                //Guardamos el nombre de la carta nueva
                nameCart = (sender as ContentControl).Name;

                if (carta != null)
                    //Dejamos la otra con su opacidad al maximo
                    (carta.Content as Grid).Opacity = 1;

                //Guardamos el contentControl
                carta = (sender as ContentControl);

                //Cojo el grid de dentro
                Grid aux = (carta.Content as Grid);

                //Y cambio su opacidad
                if (aux.Opacity == 1)
                    aux.Opacity = 0.5;
                else
                    aux.Opacity = 1;

            }
            else
            {
                //Cojo el grid de dentro
                Grid aux = (carta.Content as Grid);

                //Y cambio su opacidad
                if (aux.Opacity == 1)
                    aux.Opacity = 0.5;
                else
                    aux.Opacity = 1;

                carta = null;
                nameCart = "";
            }
        }

        private void PuttingCard(object sender, PointerRoutedEventArgs e)
        {
            //Grid aux = ((sender as ContentControl).Content as Grid);
            //aux = (carta.Content as Grid);

            (sender as ContentControl).Content = carta.Content;
            //carta.IsEnabled = false;

        }
    }
}
