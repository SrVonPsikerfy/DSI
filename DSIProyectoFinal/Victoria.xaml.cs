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
    public sealed partial class Victoria : Page
    {
        public Victoria()
        {
            this.InitializeComponent();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            StoreKnights.Prize += int.Parse(iridiumCount.Text);

            foreach (Knight knight in Teams.teamSelected)
            {
                knight.CurrentExp += int.Parse(expCount.Text);
                if (knight.CurrentExp >= knight.MaxExp)
                    knight.CurrentExp -= knight.MaxExp;
            }
        }

        private void GoToMainMenu(object sender, RoutedEventArgs e)
        {
            while (this.Frame.CanGoBack)
                Frame.GoBack();
        }

        private void GoToLevelSelect(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ModoHistoria));
        }
    }
}
