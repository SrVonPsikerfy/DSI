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
        //static private List<Knight> Team1 { get; set; } = new List<Knight>()
        //{
        //    new Knight(
        //            "Knight 1",
        //            "ms-appx:///Assets/Knights/stickman1.png",
        //            Knight.Rol.Defender,
        //            23,
        //            5,
        //            6,
        //            7,
        //            8,
        //            9,
        //            10,
        //            1,
        //            69,
        //            210,
        //            420,
        //            21,
        //            new bool[3]{ true, false, true},
        //            new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
        //        ),
        //    new Knight(
        //            "Knight 2",
        //            "ms-appx:///Assets/Knights/stickman2.png",
        //            Knight.Rol.Defender,
        //            23,
        //            5,
        //            6,
        //            7,
        //            8,
        //            9,
        //            10,
        //            1,
        //            69,
        //            210,
        //            420,
        //            21,
        //            new bool[3]{ true, false, true},
        //            new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
        //        ),
        //    new Knight(
        //            "Drak",
        //            "ms-appx:///Assets/Knights/stickman1.png",
        //            Knight.Rol.Support,
        //            23,
        //            5,
        //            6,
        //            7,
        //            8,
        //            9,
        //            10,
        //            1,
        //            69,
        //            210,
        //            420,
        //            21,
        //            new bool[3]{ true, false, true},
        //            new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
        //        ),
        //    new Knight(
        //            "Ukeo",
        //            "ms-appx:///Assets/Knights/stickman3.png",
        //            Knight.Rol.Melee,
        //            23,
        //            5,
        //            6,
        //            7,
        //            8,
        //            9,
        //            10,
        //            1,
        //            69,
        //            210,
        //            420,
        //            21,
        //            new bool[3]{ true, false, true},
        //            new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
        //        ),
        //    new Knight(
        //            "Florida",
        //            "ms-appx:///Assets/Knights/stickman4.png",
        //            Knight.Rol.Sniper,
        //            23,
        //            5,
        //            6,
        //            7,
        //            8,
        //            9,
        //            10,
        //            1,
        //            69,
        //            210,
        //            420,
        //            21,
        //            new bool[3]{ true, false, true},
        //            new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
        //        ),
        //    new Knight(
        //            "Pocahontas",
        //           "ms-appx:///Assets/Knights/stickman5.png",
        //            Knight.Rol.Healer,
        //            23,
        //            5,
        //            6,
        //            7,
        //            8,
        //            9,
        //            10,
        //            1,
        //            69,
        //            210,
        //            420,
        //            21,
        //            new bool[3]{ true, false, true},
        //            new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
        //        ),
        //    new Knight(
        //            "Lil",
        //            "ms-appx:///Assets/Knights/stickman6.png",
        //            Knight.Rol.Defender,
        //            23,
        //            5,
        //            6,
        //            7,
        //            8,
        //            9,
        //            10,
        //            1,
        //            69,
        //            210,
        //            420,
        //            21,
        //            new bool[3]{ true, false, true},
        //            new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
        //        ),
        //    new Knight(
        //            "Pocoyo",
        //            "ms-appx:///Assets/Knights/stickman4.png",
        //            Knight.Rol.Defender,
        //            23,
        //            5,
        //            6,
        //            7,
        //            8,
        //            9,
        //            10,
        //            1,
        //            69,
        //            210,
        //            420,
        //            21,
        //            new bool[3]{ true, false, true},
        //            new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
        //        )
        //};
        //static private List<Knight> Team2 { get; set; } = new List<Knight>()
        //{
        //    new Knight(
        //            "PepsiMan",
        //            "ms-appx:///Assets/Knights/stickman3.png",
        //            Knight.Rol.Defender,
        //            23,
        //            5,
        //            6,
        //            7,
        //            8,
        //            9,
        //            10,
        //            1,
        //            69,
        //            210,
        //            420,
        //            21,
        //            new bool[3]{ true, false, true},
        //            new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
        //        ),
        //    new Knight(
        //            "Knight 2",
        //            "ms-appx:///Assets/Knights/stickman2.png",
        //            Knight.Rol.Defender,
        //            23,
        //            5,
        //            6,
        //            7,
        //            8,
        //            9,
        //            10,
        //            1,
        //            69,
        //            210,
        //            420,
        //            21,
        //            new bool[3]{ true, false, true},
        //            new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
        //        ),
        //    new Knight(
        //            "Drak",
        //            "ms-appx:///Assets/Knights/stickman1.png",
        //            Knight.Rol.Support,
        //            23,
        //            5,
        //            6,
        //            7,
        //            8,
        //            9,
        //            10,
        //            1,
        //            69,
        //            210,
        //            420,
        //            21,
        //            new bool[3]{ true, false, true},
        //            new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
        //        ),
        //    new Knight(
        //            "Ukeo",
        //            "ms-appx:///Assets/Knights/stickman1.png",
        //            Knight.Rol.Melee,
        //            23,
        //            5,
        //            6,
        //            7,
        //            8,
        //            9,
        //            10,
        //            1,
        //            69,
        //            210,
        //            420,
        //            21,
        //            new bool[3]{ true, false, true},
        //            new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
        //        ),
        //    new Knight(
        //            "Florida",
        //           "ms-appx:///Assets/Knights/stickman5.png",
        //            Knight.Rol.Sniper,
        //            23,
        //            5,
        //            6,
        //            7,
        //            8,
        //            9,
        //            10,
        //            1,
        //            69,
        //            210,
        //            420,
        //            21,
        //            new bool[3]{ true, false, true},
        //            new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
        //        ),
        //    new Knight(
        //            "Pocahontas",
        //            "ms-appx:///Assets/Knights/stickman6.png",
        //            Knight.Rol.Healer,
        //            23,
        //            5,
        //            6,
        //            7,
        //            8,
        //            9,
        //            10,
        //            1,
        //            69,
        //            210,
        //            420,
        //            21,
        //            new bool[3]{ true, false, true},
        //            new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
        //        ),
        //    new Knight(
        //            "Lil",
        //            "ms-appx:///Assets/Knights/stickman1.png",
        //            Knight.Rol.Defender,
        //            23,
        //            5,
        //            6,
        //            7,
        //            8,
        //            9,
        //            10,
        //            1,
        //            69,
        //            210,
        //            420,
        //            21,
        //            new bool[3]{ true, false, true},
        //            new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
        //        ),
        //    new Knight(
        //            "Pocoyo",
        //            "ms-appx:///Assets/Knights/stickman1.png",
        //            Knight.Rol.Defender,
        //            23,
        //            5,
        //            6,
        //            7,
        //            8,
        //            9,
        //            10,
        //            1,
        //            69,
        //            210,
        //            420,
        //            21,
        //            new bool[3]{ true, false, true},
        //            new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
        //        )
        //};
        //static private List<Knight> Team3 { get; set; } = new List<Knight>()
        //{
        //    new Knight(
        //            "Penicilina",
        //            "ms-appx:///Assets/Knights/stickman2.png",
        //            Knight.Rol.Defender,
        //            23,
        //            5,
        //            6,
        //            7,
        //            8,
        //            9,
        //            10,
        //            1,
        //            69,
        //            210,
        //            420,
        //            21,
        //            new bool[3]{ true, false, true},
        //            new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
        //        ),
        //    new Knight(
        //            "Knight 2",
        //            "ms-appx:///Assets/Knights/stickman1.png",
        //            Knight.Rol.Defender,
        //            23,
        //            5,
        //            6,
        //            7,
        //            8,
        //            9,
        //            10,
        //            1,
        //            69,
        //            210,
        //            420,
        //            21,
        //            new bool[3]{ true, false, true},
        //            new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
        //        ),
        //    new Knight(
        //            "Drak",
        //            "ms-appx:///Assets/Knights/stickman6.png",
        //            Knight.Rol.Support,
        //            23,
        //            5,
        //            6,
        //            7,
        //            8,
        //            9,
        //            10,
        //            1,
        //            69,
        //            210,
        //            420,
        //            21,
        //            new bool[3]{ true, false, true},
        //            new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
        //        ),
        //    new Knight(
        //            "Ukeo",
        //            "ms-appx:///Assets/Knights/stickman5.png",
        //            Knight.Rol.Melee,
        //            23,
        //            5,
        //            6,
        //            7,
        //            8,
        //            9,
        //            10,
        //            1,
        //            69,
        //            210,
        //            420,
        //            21,
        //            new bool[3]{ true, false, true},
        //            new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
        //        ),
        //    new Knight(
        //            "Florida",
        //            "ms-appx:///Assets/Knights/stickman4.png",
        //            Knight.Rol.Sniper,
        //            23,
        //            5,
        //            6,
        //            7,
        //            8,
        //            9,
        //            10,
        //            1,
        //            69,
        //            210,
        //            420,
        //            21,
        //            new bool[3]{ true, false, true},
        //            new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
        //        ),
        //    new Knight(
        //            "Pocahontas",
        //            "ms-appx:///Assets/Knights/stickman2.png",
        //            Knight.Rol.Healer,
        //            23,
        //            5,
        //            6,
        //            7,
        //            8,
        //            9,
        //            10,
        //            1,
        //            69,
        //            210,
        //            420,
        //            21,
        //            new bool[3]{ true, false, true},
        //            new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
        //        ),
        //    new Knight(
        //            "Lil",
        //            "ms-appx:///Assets/Knights/stickman1.png",
        //            Knight.Rol.Defender,
        //            23,
        //            5,
        //            6,
        //            7,
        //            8,
        //            9,
        //            10,
        //            1,
        //            69,
        //            210,
        //            420,
        //            21,
        //            new bool[3]{ true, false, true},
        //            new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
        //        ),
        //    new Knight(
        //            "Pocoyo",
        //            "ms-appx:///Assets/Knights/stickman3.png",
        //            Knight.Rol.Defender,
        //            23,
        //            5,
        //            6,
        //            7,
        //            8,
        //            9,
        //            10,
        //            1,
        //            69,
        //            210,
        //            420,
        //            21,
        //            new bool[3]{ true, false, true},
        //            new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
        //        )
        //};
        //static private List<Knight> SelectedList { get; set; }
        private List<Image> iconKnightList { get; set; } = new List<Image>();
        private List<Image> imageKnightList { get; set; } = new List<Image>();

        private List<Knight> t1 = new List<Knight>(),
            t2 = new List<Knight>(),
            t3 = new List<Knight>();

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {

            InitializeLists();
            base.OnNavigatedTo(e);
        }

        private void InitializeLists()
        {
            t1 = Teams.Team1;
            t2 = Teams.Team2;
            t3 = Teams.Team3;

            iconKnightList.Add(TeamMemberIcon1);
            iconKnightList.Add(TeamMemberIcon2);
            iconKnightList.Add(TeamMemberIcon3);
            iconKnightList.Add(TeamMemberIcon4);
            iconKnightList.Add(TeamMemberIcon5);
            iconKnightList.Add(TeamMemberIcon6);
            iconKnightList.Add(TeamMemberIcon7);
            iconKnightList.Add(TeamMemberIcon8);

            imageKnightList.Add(TeamMemberImage1);
            imageKnightList.Add(TeamMemberImage2);
            imageKnightList.Add(TeamMemberImage3);
            imageKnightList.Add(TeamMemberImage4);
            imageKnightList.Add(TeamMemberImage5);
            imageKnightList.Add(TeamMemberImage6);
            imageKnightList.Add(TeamMemberImage7);
            imageKnightList.Add(TeamMemberImage8);

            UpdateKnight(t1);
        }

        public TeamSelect()
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

        private void GoToTeamConfig(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(TeamConfig));
        }
        private void GoToMainMenu(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainMenu));
        }
        private void GoToSettings(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Opciones));
        }

        private void SelectTeam1(object sender, RoutedEventArgs e)
        {
            TeamSelect1.BorderThickness = new Thickness(7);
            TeamSelect2.BorderThickness = new Thickness(2);
            TeamSelect3.BorderThickness = new Thickness(2);
            UpdateKnight(t1);
        }

        private void SelectTeam2(object sender, RoutedEventArgs e)
        {
            TeamSelect1.BorderThickness = new Thickness(2);
            TeamSelect2.BorderThickness = new Thickness(7);
            TeamSelect3.BorderThickness = new Thickness(2);
            UpdateKnight(t2);
        }

        private void SelectTeam3(object sender, RoutedEventArgs e)
        {
            TeamSelect1.BorderThickness = new Thickness(2);
            TeamSelect2.BorderThickness = new Thickness(2);
            TeamSelect3.BorderThickness = new Thickness(7);
            UpdateKnight(t3);
        }

        private void UpdateKnight(List<Knight> selectedTeam)
        {
            for (int i = 0; i < iconKnightList.Count(); i++)
            {
                string stringUrl = selectedTeam[i].RoleLocation;
                iconKnightList[i].Source = new BitmapImage(new Uri(stringUrl));//"ms-appx:///Assets/atacanteSelectedIcon.png"
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

      
    }
}
