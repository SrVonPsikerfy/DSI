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
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Media.Imaging;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace DSIProyectoFinal
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class TeamSelect : Page
    {
        private IList<Knight> selectedTeam = null;
        private List<Image> iconKnightList { get; set; } = null;
        private List<Image> imageKnightList { get; set; } = null;

        public TeamSelect()
        {
            this.InitializeComponent();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {

            InitializeLists();
            base.OnNavigatedTo(e);
        }

        private void InitializeLists()
        {
            iconKnightList = new List<Image>() { TeamMemberIcon1, TeamMemberIcon2, TeamMemberIcon3,
                TeamMemberIcon4, TeamMemberIcon5, TeamMemberIcon6, TeamMemberIcon7, TeamMemberIcon8 };

            imageKnightList = new List<Image>() { TeamMemberImage1, TeamMemberImage2, TeamMemberImage3, TeamMemberImage4,
                TeamMemberImage5, TeamMemberImage6, TeamMemberImage7, TeamMemberImage8 };

            UpdateKnight(Teams.Team1);
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
            }
        }

        private void GoToTeamConfig(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(TeamConfig));
        }

        private void GoToMainMenu(object sender, RoutedEventArgs e)
        {
            while (this.Frame.CanGoBack)
                this.Frame.GoBack();
        }

        private void GoToSettings(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Opciones));
        }

        private void SelectTeam1(object sender, RoutedEventArgs e)
        {
            selectedTeam = Teams.Team1;

            TeamSelect1.BorderThickness = new Thickness(7);
            TeamSelect2.BorderThickness = new Thickness(2);
            TeamSelect3.BorderThickness = new Thickness(2);
            UpdateKnight(Teams.Team1);
        }

        private void SelectTeam2(object sender, RoutedEventArgs e)
        {
            selectedTeam = Teams.Team2;

            TeamSelect1.BorderThickness = new Thickness(2);
            TeamSelect2.BorderThickness = new Thickness(7);
            TeamSelect3.BorderThickness = new Thickness(2);
            UpdateKnight(Teams.Team2);
        }

        private void SelectTeam3(object sender, RoutedEventArgs e)
        {
            selectedTeam = Teams.Team3;

            TeamSelect1.BorderThickness = new Thickness(2);
            TeamSelect2.BorderThickness = new Thickness(2);
            TeamSelect3.BorderThickness = new Thickness(7);
            UpdateKnight(Teams.Team3);
        }

        private void UpdateKnight(List<Knight> selectedTeam)
        {
            for (int i = 0; i < iconKnightList.Count(); i++)
            {
                string stringUrl = selectedTeam[i].RoleLocation;
                iconKnightList[i].Source = new BitmapImage(new Uri(stringUrl)); //"ms-appx:///Assets/atacanteSelectedIcon.png"
                imageKnightList[i].Source = new BitmapImage(new Uri(selectedTeam[i].ImageLocation));
            }
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

        private void Go(object sender, RoutedEventArgs e)
        {
            Teams.teamSelected = selectedTeam;
            this.Frame.Navigate(typeof(Defensa));
        }
    }
}
