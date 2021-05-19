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

        private string nameCart;
        bool clicked = false;

        private ContentControl carta;
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
                ContentControl cell = sender as ContentControl;
                string cellName = cell.Name;
                //pillo la imagen por su nombre
                int posicion = int.Parse(cellName[7].ToString()) * 8 + int.Parse(cellName[8].ToString()); //8??
                KnightsOnGrid[posicion] = SelectedTeam[IndexOfSelectedKnight];
                //Image icono = cell.FindName("gridImage" + cellName[7] + cellName[8]);

                //car.GetType().GetProperty(propertyName).GetValue(car, null);
                //MAAAAAAAAL
                //cell.Content = (new BitmapImage(new Uri("ms-appx:///Assets/Knights/stickman1.png")));

                //index = int.Parse((sender as Button).Name[1].ToString()) - 1; content01 7 y 8
            }
        }
    }
}
