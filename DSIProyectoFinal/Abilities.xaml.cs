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
using System.Reflection;
using System.ComponentModel;
using Windows.UI.Xaml.Media.Imaging;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace DSIProyectoFinal
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Abilities : Page
    {
        private ObservableCollection<Knight> Knights { get; set; } = new ObservableCollection<Knight>();
        private ObservableCollection<Skill> Skills { get; set; } = new ObservableCollection<Skill>();

        //Knight selectedKnight;
        private ObservableCollection<Knight> selectedKnight { get; set; } = new ObservableCollection<Knight>();
        public Abilities()
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

            //// Remove this when replaced with XAML bindings
            //GridSelect.ItemsSource = Knights;

            selectedKnight.Add(Knights[2]);

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

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void KnightSelection(object sender, ItemClickEventArgs e)
        {
            Knight k = e.ClickedItem as Knight;
            Skills.Clear();
            foreach (Skill skill in k.Abilities)
            {
                Skills.Add(skill);
            }
            selectedKnight[0] = k;            
        }

        private void AbilitySelection(object sender, ItemClickEventArgs e)
        {
            Skill skill = e.ClickedItem as Skill;
            
            if (!skill.IsUnlocked) UnlockAbility(skill);


            //actualizar imagen desbloqueada
            int index = Skills.IndexOf(skill);
            GridSkills.SelectedIndex = index;
            
        }

        private void UnlockAbility(Skill skill)
        {
            skill.UnlockAbility();
            //buscarla y cargarla
            GridViewItem gridViewItem = (GridViewItem)this.GridSkills.ContainerFromIndex(index);
            if (gridViewItem != null)
            {
                (FindByName("skillImage", gridViewItem) as Image).Source = new BitmapImage(new Uri(skill.ImageSource)); ;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

        }


        private FrameworkElement FindByName(string name, FrameworkElement root)
        {
            Stack<FrameworkElement> tree = new Stack<FrameworkElement>();
            tree.Push(root);

            while (tree.Count > 0)
            {
                FrameworkElement current = tree.Pop();
                if (current.Name == name)
                    return current;

                int count = VisualTreeHelper.GetChildrenCount(current);
                for (int i = 0; i < count; ++i)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(current, i);
                    if (child is FrameworkElement)
                        tree.Push((FrameworkElement)child);
                }
            }

            return null;
        }
    }
}
