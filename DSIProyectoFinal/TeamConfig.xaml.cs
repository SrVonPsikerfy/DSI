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
        //CABALLEROS DISPONIBLES DEL GRID DERECHO
        private ObservableCollection<Knight> Knights { get; set; } = new ObservableCollection<Knight>();


        //ICONOS
        private List<Image> iconKnightList { get; set; } = null;
        private List<Image> imageKnightList { get; set; } = null;
        private List<Button> buttonKnightList { get; set; } = null;
        private List<TextBlock> nameKnightList { get; set; } = null;

        //CABALLERO SELECCIONADO Y DEL GRID
        private Knight selectedKnight = null;
        private Knight gridKnight = null;
        int index = -1;

        int SelectedTeamIndex = 1;
        //EQUIPOS CONFIGURABLES
        private List<List<Knight>> teamList = new List<List<Knight>>();
        //EQUIPO TEMPORAL QUE SE VA CREANDO
        private List<Knight> auxTeam = new List<Knight>();

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

            teamList.Add(new List<Knight>(Teams.Team1));
            teamList.Add(new List<Knight>(Teams.Team2));
            teamList.Add(new List<Knight>(Teams.Team3));

            iconKnightList = new List<Image>() { TeamMemberIcon1, TeamMemberIcon2, TeamMemberIcon3,
                TeamMemberIcon4, TeamMemberIcon5, TeamMemberIcon6, TeamMemberIcon7, TeamMemberIcon8 };

            imageKnightList = new List<Image>() { TeamMemberImage1, TeamMemberImage2, TeamMemberImage3, TeamMemberImage4,
                TeamMemberImage5, TeamMemberImage6, TeamMemberImage7, TeamMemberImage8 };

            buttonKnightList = new List<Button>() { b1, b2, b3, b4, b5, b6, b7, b8 };

            nameKnightList = new List<TextBlock>() { TeamMemberName1, TeamMemberName2, TeamMemberName3, TeamMemberName4,
                TeamMemberName5, TeamMemberName6, TeamMemberName7, TeamMemberName8 };

            SelectedTeamIndex = 0;
            UpdateKnights(teamList[SelectedTeamIndex]);

            base.OnNavigatedTo(e);
        }

        private void SelectTeam1(object sender, RoutedEventArgs e)
        {
            Sounds.playSound("button.wav");
            Select1.BorderThickness = new Thickness(7);
            Select2.BorderThickness = new Thickness(2);
            Select3.BorderThickness = new Thickness(2);
            SelectedTeamIndex = 0;
            UpdateKnights(teamList[SelectedTeamIndex]);
        }

        private void SelectTeam2(object sender, RoutedEventArgs e)
        {
            Sounds.playSound("button.wav");
            Select1.BorderThickness = new Thickness(2);
            Select2.BorderThickness = new Thickness(7);
            Select3.BorderThickness = new Thickness(2);
            SelectedTeamIndex = 1;
            UpdateKnights(teamList[SelectedTeamIndex]);
        }

        private void SelectTeam3(object sender, RoutedEventArgs e)
        {
            Sounds.playSound("button.wav");
            Select1.BorderThickness = new Thickness(2);
            Select2.BorderThickness = new Thickness(2);
            Select3.BorderThickness = new Thickness(7);
            SelectedTeamIndex = 2;
            UpdateKnights(teamList[SelectedTeamIndex]);
        }

        private void UpdateKnights(List<Knight> selectedTeam)
        {
            auxTeam = new List<Knight>(selectedTeam);

            for (int i = 0; i < iconKnightList.Count(); i++)
            {
                string stringUrl = selectedTeam[i].RoleLocation;
                iconKnightList[i].Source = new BitmapImage(new Uri(stringUrl)); //"ms-appx:///Assets/atacanteSelectedIcon.png"
                imageKnightList[i].Source = new BitmapImage(new Uri(selectedTeam[i].ImageLocation));
                nameKnightList[i].Text = selectedTeam[i].Name;
            }
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            Sounds.playSound("button.wav");
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Sounds.playSound("button.wav");
            index = int.Parse((sender as Button).Name[1].ToString()) - 1;
            selectedKnight = auxTeam[index];
            //me parece muy lioso hacer que en ambos se cambie el personaje, y me da problemas
            if (gridKnight != null)
            {
                ChangeChar();
            }
        }

        private void Available_Select(object sender, ItemClickEventArgs e)
        {
            Sounds.playSound("button.wav");

            gridKnight = (Knight)e.ClickedItem;

            if (selectedKnight != null)
            {
                ChangeChar();
            }
        }

        private bool ContainsKnight(Knight gridKnight)
        {
            foreach (Knight knight in auxTeam)
            {
                if (knight.Name == gridKnight.Name) return true;
            }
            return false;
        }

        private void ChangeChar()
        {
            if (selectedKnight.Name != gridKnight.Name && !ContainsKnight(gridKnight))
            {
                auxTeam[index] = gridKnight;
                imageKnightList[index].Source = new BitmapImage(new Uri(auxTeam[index].ImageLocation));
                iconKnightList[index].Source = new BitmapImage(new Uri(auxTeam[index].RoleLocation));
                nameKnightList[index].Text = auxTeam[index].Name;
            }

            index = -1;
            gridKnight = null;
            selectedKnight = null;
            GridSelect.SelectedItem = null;
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

        private void SaveTeam(object sender, RoutedEventArgs e)
        {
            Sounds.playSound("button.wav");
            Teams.SaveList(auxTeam, SelectedTeamIndex);
            teamList[SelectedTeamIndex] = new List<Knight>(auxTeam);
        }
    }
}
