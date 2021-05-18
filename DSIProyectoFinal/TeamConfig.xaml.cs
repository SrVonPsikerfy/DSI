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
    public sealed partial class TeamConfig : Page
    {
        private ObservableCollection<Knight> Knights { get; set; } = new ObservableCollection<Knight>();

        private List<Knight> t1 = new List<Knight>(),
            t2 = new List<Knight>(),
            t3 = new List<Knight>(),
            tAux = null;

        private List<Image> iconKnightList { get; set; } = null;
        private List<Image> imageKnightList { get; set; } = null;

        private Knight selectedKnight = null;
        private Knight gridKnight = null;
        int index = -1;


        public TeamConfig()
        {
            this.InitializeComponent();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (Knights != null)
                foreach (Knight knight in AvailableKnights.GetAvailableKnights())
                {
                    Knights.Add(new Knight(knight));
                }

            t1 = new List<Knight>(Teams.Team1);
            t2 = new List<Knight>(Teams.Team2);
            t3 = new List<Knight>(Teams.Team3);

            iconKnightList = new List<Image>() { TeamMemberIcon1, TeamMemberIcon2, TeamMemberIcon3,
                TeamMemberIcon4, TeamMemberIcon5, TeamMemberIcon6, TeamMemberIcon7, TeamMemberIcon8 };

            imageKnightList = new List<Image>() { TeamMemberImage1, TeamMemberImage2, TeamMemberImage3, TeamMemberImage4,
                TeamMemberImage5, TeamMemberImage6, TeamMemberImage7, TeamMemberImage8 };

            UpdateKnight(t1);

            base.OnNavigatedTo(e);
        }

        private void SelectTeam1(object sender, RoutedEventArgs e)
        {
            Select1.BorderThickness = new Thickness(7);
            Select2.BorderThickness = new Thickness(2);
            Select3.BorderThickness = new Thickness(2);
            UpdateKnight(t1);
        }

        private void SelectTeam2(object sender, RoutedEventArgs e)
        {
            Select1.BorderThickness = new Thickness(2);
            Select2.BorderThickness = new Thickness(7);
            Select3.BorderThickness = new Thickness(2);
            UpdateKnight(t2);
        }

        private void SelectTeam3(object sender, RoutedEventArgs e)
        {
            Select1.BorderThickness = new Thickness(2);
            Select2.BorderThickness = new Thickness(2);
            Select3.BorderThickness = new Thickness(7);
            UpdateKnight(t3);
        }

        private void UpdateKnight(List<Knight> selectedTeam)
        {
            tAux = selectedTeam;

            for (int i = 0; i < iconKnightList.Count(); i++)
            {
                string stringUrl = selectedTeam[i].RoleLocation;
                iconKnightList[i].Source = new BitmapImage(new Uri(stringUrl)); //"ms-appx:///Assets/atacanteSelectedIcon.png"
                imageKnightList[i].Source = new BitmapImage(new Uri(selectedTeam[i].ImageLocation));
            }
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            index = int.Parse((sender as Button).Name[1].ToString()) - 1;
            selectedKnight = Knights[index];
            if (gridKnight != null)
            {
                ChangeChar();
            }
        }

        private void Available_Select(object sender, ItemClickEventArgs e)
        {
            gridKnight = (Knight)e.ClickedItem;

            if (selectedKnight != null)
            {
                ChangeChar();
            }
        }

        private void ChangeChar()
        {
            if (selectedKnight != gridKnight && !tAux.Contains(gridKnight))
            {
                tAux[index] = gridKnight;
                imageKnightList[index].Source = new BitmapImage(new Uri(tAux[index].ImageLocation));
                iconKnightList[index].Source = new BitmapImage(new Uri(tAux[index].RoleLocation));
            }

            index = -1;
            gridKnight = null;
            selectedKnight = null;
            GridSelect.SelectedItem = null;
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
