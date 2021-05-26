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
using System.Collections.ObjectModel;
using System.Reflection;
using System.ComponentModel;


// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace DSIProyectoFinal
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Defensa : Page
    {
        public List<ContentControl> Members;
        ContentControl MemberSelected = null;
        public ObservableCollection<Knight> SelectedTeam = new ObservableCollection<Knight>();
        //filas 0->3, cols 0->7
        public ObservableCollection<Knight> KnightsOnGrid = new ObservableCollection<Knight>();
        int IndexOfSelectedKnight = -1;

        int ManaPoints = 200;
        int EnemyTotal = 10;
        int EnemyCounter = 0;
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

            for (int i = 0; i < 32; i++) KnightsOnGrid.Add(null);
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
            Sounds.playSound("button.wav");
            this.Frame.Navigate(typeof(Pause));
        }

        private void Grid_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Sounds.playSound("button.wav");
            if (e.OriginalKey == Windows.System.VirtualKey.GamepadB && e.Key == Windows.System.VirtualKey.Escape || e.Key == Windows.System.VirtualKey.GamepadMenu)
            {
                if (this.Frame.CanGoBack)
                {
                    this.Frame.Navigate(typeof(Pause));
                }
            }
        }

        private void ContentControl_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            Sounds.playSound("button.wav");
            //Cojo el grid de dentro
            Grid contentGrid = ((sender as ContentControl).Content as Grid);

            //Si es el mismo, deselecciono
            if (MemberSelected == sender as ContentControl)
            {
                MemberSelected = null;
                contentGrid.Opacity = 1;
                IndexOfSelectedKnight = -1;
            }
            else //Si es distinto...
            {
                //si no habia ninguno seleccionado, lo selecciono
                if(MemberSelected == null)
                {
                    MemberSelected = sender as ContentControl;
                    IndexOfSelectedKnight = int.Parse(MemberSelected.Name[10].ToString()) - 1;
                    contentGrid.Opacity = 0.5;
                }
                //else //si habia uno ya seleccionado y es distinto no hago nada
            }
        }

         private void MovingCard(object sender, PointerRoutedEventArgs e)
        {
            if(MemberSelected != null)
            {
                Sounds.playSound("button.wav");
                ContentControl cell = sender as ContentControl;
                //pillo la imagen por su nombre
                int posicion = int.Parse(cell.Name[7].ToString()) * 8 + int.Parse(cell.Name[8].ToString()); //8??
                if(KnightsOnGrid[posicion] == null)
                {
                    KnightsOnGrid[posicion] = SelectedTeam[IndexOfSelectedKnight];
                    //se esconde el caballero seleccionado
                    MemberSelected.Visibility = Visibility.Collapsed;
                    MemberSelected = null;
                    //gastar puntos
                    ManaPoints -= KnightsOnGrid[posicion].Mana;
                    manaPointsText.Text = ManaPoints.ToString();
                    //HABILIDADES
                    StackPanel skillStackPanel = cell.FindName("panel" + cell.Name[7].ToString() + cell.Name[8].ToString()) as StackPanel;
                    if(skillStackPanel != null)
                    {
                        int i = 0;
                        foreach (Skill skill in KnightsOnGrid[posicion].EquipedAbilities)
                        {
                            Image image = new Image();
                            image.Source = new BitmapImage(new Uri(skill.ImageSource));
                            skillStackPanel.Children.Add(image);
                            i++;
                        }
                        while (i < 3)
                        {
                            Image image = new Image();
                            image.Source = new BitmapImage(new Uri("ms-appx:///Assets/skills/skill_locked.png"));
                            skillStackPanel.Children.Add(image);
                            i++;
                        }
                    }
                }
            }
        }
        private void AutoWin_Click(object sender, RoutedEventArgs e)
        {
            Sounds.playSound("button.wav");
            EnemyCounter++;
            enemyProgressBar.Value = ((float)EnemyCounter / (float)EnemyTotal) * 100;
            enemyCounterText.Text = EnemyCounter.ToString();
            enemyTotalText.Text = EnemyTotal.ToString();
            
            if(EnemyCounter >= EnemyTotal)
            {
                this.Frame.Navigate(typeof(Victoria));
            }
            
        }

        private void MovingCardOnKeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.OriginalKey == Windows.System.VirtualKey.GamepadA)
            {
                if (MemberSelected != null)
                {
                    Sounds.playSound("button.wav");
                    ContentControl cell = sender as ContentControl;
                    //pillo la imagen por su nombre
                    int posicion = int.Parse(cell.Name[7].ToString()) * 8 + int.Parse(cell.Name[8].ToString()); //8??
                    if (KnightsOnGrid[posicion] == null)
                    {
                        KnightsOnGrid[posicion] = SelectedTeam[IndexOfSelectedKnight];
                        //se esconde el caballero seleccionado
                        MemberSelected.Visibility = Visibility.Collapsed;
                        MemberSelected = null;
                        //gastar puntos
                        ManaPoints -= KnightsOnGrid[posicion].Mana;
                        manaPointsText.Text = ManaPoints.ToString();
                        //HABILIDADES
                        StackPanel skillStackPanel = cell.FindName("panel" + cell.Name[7].ToString() + cell.Name[8].ToString()) as StackPanel;
                        if (skillStackPanel != null)
                        {
                            int i = 0;
                            foreach (Skill skill in KnightsOnGrid[posicion].EquipedAbilities)
                            {
                                Image image = new Image();
                                image.Source = new BitmapImage(new Uri(skill.ImageSource));
                                skillStackPanel.Children.Add(image);
                                i++;
                            }
                            while (i < 3)
                            {
                                Image image = new Image();
                                image.Source = new BitmapImage(new Uri("ms-appx:///Assets/skills/skill_locked.png"));
                                skillStackPanel.Children.Add(image);
                                i++;
                            }
                        }
                    }
                }
            }
              
        }

        private void ContentControlKeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.OriginalKey == Windows.System.VirtualKey.GamepadA)
            {
                Sounds.playSound("button.wav");
                //Cojo el grid de dentro
                Grid contentGrid = ((sender as ContentControl).Content as Grid);

                //Si es el mismo, deselecciono
                if (MemberSelected == sender as ContentControl)
                {
                    MemberSelected = null;
                    contentGrid.Opacity = 1;
                    IndexOfSelectedKnight = -1;
                }
                else //Si es distinto...
                {
                    //si no habia ninguno seleccionado, lo selecciono
                    if (MemberSelected == null)
                    {
                        MemberSelected = sender as ContentControl;
                        IndexOfSelectedKnight = int.Parse(MemberSelected.Name[10].ToString()) - 1;
                        contentGrid.Opacity = 0.5;
                    }
                    //else //si habia uno ya seleccionado y es distinto no hago nada
                }
            }
        }
    }
}
