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
        private List<Skill> SelectedSkills { get; set; } = new List<Skill>();
        private List<Image> SelectedSkillsImages { get; set; } = new List<Image>();

        Skill skill = null;
        Image image = null;
        int index = -1;

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

            InitializeSelectedSkillsImages();
            selectedKnight.Add(Knights[0]);
            SelectKnight(selectedKnight[0]);
            base.OnNavigatedTo(e);
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            AvailableKnights.UpdateAvailableKnights(Knights.ToList());
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
            }
        }

        private void InitializeSelectedSkillsImages()
        {
            SelectedSkillsImages.Add(SelectedSkillImage1);
            SelectedSkillsImages.Add(SelectedSkillImage2);
            SelectedSkillsImages.Add(SelectedSkillImage3);
        }

        private void GoToMainMenu(object sender, RoutedEventArgs e)
        {
            AvailableKnights.UpdateAvailableKnights(Knights.ToList());
            while (this.Frame.CanGoBack)
                Frame.GoBack();
        }

        private void GoToSettings(object sender, RoutedEventArgs e)
        {
            AvailableKnights.UpdateAvailableKnights(Knights.ToList());
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

        private void KnightSelection(object sender, ItemClickEventArgs e)
        {
            Knight k = e.ClickedItem as Knight;
            SelectKnight(k);
        }

        private void SelectKnight(Knight knight)
        {
            Skills.Clear();
            foreach (Skill skill in knight.Abilities)
            {
                Skills.Add(skill);
            }
            selectedKnight[0] = knight;
            UpdateSelectedSkills();
            UpdateExpProgressBar();
        }

        private void UpdateExpProgressBar()
        {
           progressBar.Value = ((float) selectedKnight[0].CurrentExp / (float) selectedKnight[0].MaxExp) * 100;
        }

        private void AbilitySelection(object sender, ItemClickEventArgs e)
        {
            skill = e.ClickedItem as Skill;

            //actualizar imagen desbloqueada
            index = Skills.IndexOf(skill);
            GridSkills.SelectedIndex = index;

            //se obtiene el gridViewItem
            GridViewItem gridViewItem = (GridViewItem)this.GridSkills.ContainerFromIndex(index);

            if (gridViewItem != null) image = (FindByName("skillImage", gridViewItem) as Image);

            if (!skill.IsUnlocked)
            {
                FalseBackground.Visibility = Visibility.Visible;
                ConfirmBox.Visibility = Visibility.Visible;
                TextConfirm.Text = "Buy skill?";
            }
            else 
            {
                //EQUIPADA?
                if (skill.IsActive)
                {
                    FalseBackground.Visibility = Visibility.Visible;
                    ConfirmBox.Visibility = Visibility.Visible;
                    TextConfirm.Text = "Unequip skill?";
                }
                //NO EQUIPADA
                else if (selectedKnight[0].EquipedAbilities.Count() < 3)
                {
                    FalseBackground.Visibility = Visibility.Visible;
                    ConfirmBox.Visibility = Visibility.Visible;
                    TextConfirm.Text = "Equip skill?";
                }
            }
        }

        private void UnlockAbility(Skill skill, int index, Image image)
        {
            if (selectedKnight[0].PointsAvailable >= skill.PointsNeeded)
            {
                //se actualiza el source
                skill.UnlockAbility();
                //buscarla y cargarla
                //se carga el source
                image.Source = new BitmapImage(new Uri(skill.ImageSource));
                selectedKnight[0].PointsAvailable -= skill.PointsNeeded;
                AvailablePoints.Text = selectedKnight[0].PointsAvailable.ToString();

                skill.CostVisibility = Visibility.Collapsed;

                GridViewItem gridViewItem = (GridViewItem)this.GridSkills.ContainerFromIndex(index);
                if (gridViewItem != null) (FindByName("skillCircleOfPoint", gridViewItem) as Image).Visibility = Visibility.Collapsed;


                gridViewItem = (GridViewItem)this.GridSkills.ContainerFromIndex(index);
                if (gridViewItem != null) (FindByName("skillPointsNeeded", gridViewItem) as TextBlock).Visibility = Visibility.Collapsed;
            }
        }

        private void EquipAbility(Skill skill, Image image)
        {
            if (selectedKnight[0].EquipedAbilities.Count < 3)
            {
                //se actualiza el source
                skill.EquipAbility();
                int nextFreeSkillIndex = selectedKnight[0].EquipedAbilities.Count;
                SelectedSkills.Add(skill);
                selectedKnight[0].EquipedAbilities.Add(skill);
                SelectedSkillsImages[nextFreeSkillIndex].Source = new BitmapImage(new Uri(skill.ImageSource));
                image.Source = new BitmapImage(new Uri(skill.ImageSource));
                UpdateSelectedSkills();
            }
        }


        private void UnequipAbility(Skill skill, Image image)
        {
            for (int i = 0; i < selectedKnight[0].EquipedAbilities.Count; i++)
            {
                if (SelectedSkills[i] == skill)
                {
                    skill.UnequipAbility();
                    SelectedSkills.RemoveAt(i);
                    selectedKnight[0].EquipedAbilities.RemoveAt(i);
                    SelectedSkillsImages[i].Source = new BitmapImage(new Uri("ms-appx:///Assets/skills/skill_not_used.png"));
                    image.Source = new BitmapImage(new Uri(skill.ImageSource));
                    UpdateSelectedSkills();
                    break;
                }
            }
        }

        private void UpdateSelectedSkills()
        {
            //el clear da error
            SelectedSkills.Clear();
            int i = 0;
            //se meten las habilidades equipadas
            while (i < selectedKnight[0].EquipedAbilities.Count)
            {
                SelectedSkills.Add(selectedKnight[0].EquipedAbilities[i]);
                SelectedSkillsImages[i].Source = new BitmapImage(new Uri(selectedKnight[0].EquipedAbilities[i].ImageSource));
                i++;
            }
            //se meten imagenes de relleno para el resto que no tienen mas habilidades equipadas
            while (i < 3)
            {
                SelectedSkillsImages[i].Source = new BitmapImage(new Uri("ms-appx:///Assets/skills/skill_not_used.png"));
                i++;
            }
        }

        private void No_Click(object sender, RoutedEventArgs e)
        {
            FalseBackground.Visibility = Visibility.Collapsed;
            ConfirmBox.Visibility = Visibility.Collapsed;
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            if (!skill.IsUnlocked) UnlockAbility(skill, index, image);
            else
            {
                //EQUIPADA?
                if (skill.IsActive) UnequipAbility(skill, image);
                //NO EQUIPADA
                else EquipAbility(skill, image);
            }

            skill = null;
            image = null;
            index = -1;

            FalseBackground.Visibility = Visibility.Collapsed;
            ConfirmBox.Visibility = Visibility.Collapsed;
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
