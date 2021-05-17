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
        static private List<Knight> Team1 { get; set; } = new List<Knight>()
        {
            new Knight(
                    "Knight 1",
                    "Assets/stick-man-hi-small.png",
                    Knight.Rol.Defender,
                    23,
                    5,
                    6,
                    7,
                    8,
                    9,
                    10,
                    1,
                    69,
                    210,
                    420,
                    21,
                    new bool[3]{ true, false, true},
                    new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
                ),
            new Knight(
                    "Knight 2",
                    "Assets/stick-man-hi-small.png",
                    Knight.Rol.Defender,
                    23,
                    5,
                    6,
                    7,
                    8,
                    9,
                    10,
                    1,
                    69,
                    210,
                    420,
                    21,
                    new bool[3]{ true, false, true},
                    new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
                ),
            new Knight(
                    "Drak",
                    "Assets/stick-man-hi-small.png",
                    Knight.Rol.Support,
                    23,
                    5,
                    6,
                    7,
                    8,
                    9,
                    10,
                    1,
                    69,
                    210,
                    420,
                    21,
                    new bool[3]{ true, false, true},
                    new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
                ),
            new Knight(
                    "Ukeo",
                    "Assets/stick-man-hi-small.png",
                    Knight.Rol.Melee,
                    23,
                    5,
                    6,
                    7,
                    8,
                    9,
                    10,
                    1,
                    69,
                    210,
                    420,
                    21,
                    new bool[3]{ true, false, true},
                    new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
                ),
            new Knight(
                    "Florida",
                    "Assets/stick-man-hi-small.png",
                    Knight.Rol.Sniper,
                    23,
                    5,
                    6,
                    7,
                    8,
                    9,
                    10,
                    1,
                    69,
                    210,
                    420,
                    21,
                    new bool[3]{ true, false, true},
                    new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
                ),
            new Knight(
                    "Pocahontas",
                    "Assets/stick-man-hi-small.png",
                    Knight.Rol.Healer,
                    23,
                    5,
                    6,
                    7,
                    8,
                    9,
                    10,
                    1,
                    69,
                    210,
                    420,
                    21,
                    new bool[3]{ true, false, true},
                    new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
                ),
            new Knight(
                    "Lil",
                    "Assets/stick-man-hi-small.png",
                    Knight.Rol.Defender,
                    23,
                    5,
                    6,
                    7,
                    8,
                    9,
                    10,
                    1,
                    69,
                    210,
                    420,
                    21,
                    new bool[3]{ true, false, true},
                    new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
                ),
            new Knight(
                    "Pocoyo",
                    "Assets/stick-man-hi-small.png",
                    Knight.Rol.Defender,
                    23,
                    5,
                    6,
                    7,
                    8,
                    9,
                    10,
                    1,
                    69,
                    210,
                    420,
                    21,
                    new bool[3]{ true, false, true},
                    new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
                )
        };
        static private List<Knight> Team2 { get; set; } = new List<Knight>()
        {
            new Knight(
                    "PepsiMan",
                    "Assets/stick-man-hi-small.png",
                    Knight.Rol.Defender,
                    23,
                    5,
                    6,
                    7,
                    8,
                    9,
                    10,
                    1,
                    69,
                    210,
                    420,
                    21,
                    new bool[3]{ true, false, true},
                    new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
                ),
            new Knight(
                    "Knight 2",
                    "Assets/stick-man-hi-small.png",
                    Knight.Rol.Defender,
                    23,
                    5,
                    6,
                    7,
                    8,
                    9,
                    10,
                    1,
                    69,
                    210,
                    420,
                    21,
                    new bool[3]{ true, false, true},
                    new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
                ),
            new Knight(
                    "Drak",
                    "Assets/stick-man-hi-small.png",
                    Knight.Rol.Support,
                    23,
                    5,
                    6,
                    7,
                    8,
                    9,
                    10,
                    1,
                    69,
                    210,
                    420,
                    21,
                    new bool[3]{ true, false, true},
                    new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
                ),
            new Knight(
                    "Ukeo",
                    "Assets/stick-man-hi-small.png",
                    Knight.Rol.Melee,
                    23,
                    5,
                    6,
                    7,
                    8,
                    9,
                    10,
                    1,
                    69,
                    210,
                    420,
                    21,
                    new bool[3]{ true, false, true},
                    new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
                ),
            new Knight(
                    "Florida",
                    "Assets/stick-man-hi-small.png",
                    Knight.Rol.Sniper,
                    23,
                    5,
                    6,
                    7,
                    8,
                    9,
                    10,
                    1,
                    69,
                    210,
                    420,
                    21,
                    new bool[3]{ true, false, true},
                    new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
                ),
            new Knight(
                    "Pocahontas",
                    "Assets/stick-man-hi-small.png",
                    Knight.Rol.Healer,
                    23,
                    5,
                    6,
                    7,
                    8,
                    9,
                    10,
                    1,
                    69,
                    210,
                    420,
                    21,
                    new bool[3]{ true, false, true},
                    new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
                ),
            new Knight(
                    "Lil",
                    "Assets/stick-man-hi-small.png",
                    Knight.Rol.Defender,
                    23,
                    5,
                    6,
                    7,
                    8,
                    9,
                    10,
                    1,
                    69,
                    210,
                    420,
                    21,
                    new bool[3]{ true, false, true},
                    new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
                ),
            new Knight(
                    "Pocoyo",
                    "Assets/stick-man-hi-small.png",
                    Knight.Rol.Defender,
                    23,
                    5,
                    6,
                    7,
                    8,
                    9,
                    10,
                    1,
                    69,
                    210,
                    420,
                    21,
                    new bool[3]{ true, false, true},
                    new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
                )
        };
        static private List<Knight> Team3 { get; set; } = new List<Knight>()
        {
            new Knight(
                    "Penicilina",
                    "Assets/stick-man-hi-small.png",
                    Knight.Rol.Defender,
                    23,
                    5,
                    6,
                    7,
                    8,
                    9,
                    10,
                    1,
                    69,
                    210,
                    420,
                    21,
                    new bool[3]{ true, false, true},
                    new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
                ),
            new Knight(
                    "Knight 2",
                    "Assets/stick-man-hi-small.png",
                    Knight.Rol.Defender,
                    23,
                    5,
                    6,
                    7,
                    8,
                    9,
                    10,
                    1,
                    69,
                    210,
                    420,
                    21,
                    new bool[3]{ true, false, true},
                    new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
                ),
            new Knight(
                    "Drak",
                    "Assets/stick-man-hi-small.png",
                    Knight.Rol.Support,
                    23,
                    5,
                    6,
                    7,
                    8,
                    9,
                    10,
                    1,
                    69,
                    210,
                    420,
                    21,
                    new bool[3]{ true, false, true},
                    new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
                ),
            new Knight(
                    "Ukeo",
                    "Assets/stick-man-hi-small.png",
                    Knight.Rol.Melee,
                    23,
                    5,
                    6,
                    7,
                    8,
                    9,
                    10,
                    1,
                    69,
                    210,
                    420,
                    21,
                    new bool[3]{ true, false, true},
                    new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
                ),
            new Knight(
                    "Florida",
                    "Assets/stick-man-hi-small.png",
                    Knight.Rol.Sniper,
                    23,
                    5,
                    6,
                    7,
                    8,
                    9,
                    10,
                    1,
                    69,
                    210,
                    420,
                    21,
                    new bool[3]{ true, false, true},
                    new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
                ),
            new Knight(
                    "Pocahontas",
                    "Assets/stick-man-hi-small.png",
                    Knight.Rol.Healer,
                    23,
                    5,
                    6,
                    7,
                    8,
                    9,
                    10,
                    1,
                    69,
                    210,
                    420,
                    21,
                    new bool[3]{ true, false, true},
                    new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
                ),
            new Knight(
                    "Lil",
                    "Assets/stick-man-hi-small.png",
                    Knight.Rol.Defender,
                    23,
                    5,
                    6,
                    7,
                    8,
                    9,
                    10,
                    1,
                    69,
                    210,
                    420,
                    21,
                    new bool[3]{ true, false, true},
                    new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
                ),
            new Knight(
                    "Pocoyo",
                    "Assets/stick-man-hi-small.png",
                    Knight.Rol.Defender,
                    23,
                    5,
                    6,
                    7,
                    8,
                    9,
                    10,
                    1,
                    69,
                    210,
                    420,
                    21,
                    new bool[3]{ true, false, true},
                    new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
                )
        };
        static private List<Knight> SelectedList { get; set; }
        private List<Image> iconList { get; set; } = new List<Image>();

        public TeamSelect()
        {
            this.InitializeComponent();
            iconList.Add(TeamMemberIcon1);
            iconList.Add(TeamMemberIcon2);
            iconList.Add(TeamMemberIcon3);
            iconList.Add(TeamMemberIcon4);
            iconList.Add(TeamMemberIcon5);
            iconList.Add(TeamMemberIcon6);
            iconList.Add(TeamMemberIcon7);
            iconList.Add(TeamMemberIcon8);
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
            UpdateKnight(Team1);
        }

        private void SelectTeam2(object sender, RoutedEventArgs e)
        {
            TeamSelect1.BorderThickness = new Thickness(2);
            TeamSelect2.BorderThickness = new Thickness(7);
            TeamSelect3.BorderThickness = new Thickness(2);
            UpdateKnight(Team2);
        }

        private void SelectTeam3(object sender, RoutedEventArgs e)
        {
            TeamSelect1.BorderThickness = new Thickness(2);
            TeamSelect2.BorderThickness = new Thickness(2);
            TeamSelect3.BorderThickness = new Thickness(7);
            UpdateKnight(Team3);
        }

        private void UpdateKnight(List<Knight> selectedTeam)
        {
            int i = 0;
            foreach(Image image in iconList)
            {
                string stringUrl = selectedTeam[i].RoleLocation;
                image.Source = new BitmapImage(new Uri(stringUrl));//"ms-appx:///Assets/atacanteSelectedIcon.png"
                i++;
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
