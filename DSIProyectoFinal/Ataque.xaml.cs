﻿using System;
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
    public sealed partial class Ataque : Page
    {
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
    }
}
