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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace DSIProyectoFinal
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Defensa : Page
    {
        public List<ContentControl> Members;
        public ObservableCollection<Knight> SelectedTeam = new ObservableCollection<Knight>();
        public Defensa()
        {
            this.InitializeComponent();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            Members = new List<ContentControl>() {TeamMember1, TeamMember2, TeamMember3, TeamMember4, TeamMember5, TeamMember6, TeamMember7, TeamMember8 };
            //meter los caballeros
            foreach(Knight knight in Teams.teamSelected)
            {
                SelectedTeam.Add(new Knight(knight));
            }
            base.OnNavigatedTo(e);
        }

        private void TextBlock_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (((Frame)Window.Current.Content).ActualHeight > 540 && ((Frame)Window.Current.Content).ActualWidth > 960)
                (sender as TextBlock).FontSize = 60;
            else
                (sender as TextBlock).FontSize = 30;
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

        private void ContentControl_PointerPressed(object sender, PointerRoutedEventArgs e)
        {

        }
    }
}
