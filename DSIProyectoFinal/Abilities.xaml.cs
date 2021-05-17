using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class Abilities : Page
    {
        public Abilities()
        {
            this.InitializeComponent();
        }

        private ObservableCollection<Knight> knights { get; } = new ObservableCollection<Knight>();

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            for (int i = 0; i < 30; i++)
            {
                bool[] abilities = { true, false, true };
                int[] pickedAbilities = { 1, 2, 3 };
                knights.Add(new Knight("Knight", "Assets/Imagen.png", Knight.Rol.Defender, 100, 5, 6, 7, 8, 9, 10, 1, 69, 210, 420, 21, abilities, pickedAbilities));
            }
            // Remove this when replaced with XAML bindings
            GridSelect.ItemsSource = knights;

            base.OnNavigatedTo(e);
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
            }
        }

        private void GoToMainMenu(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainMenu));
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
