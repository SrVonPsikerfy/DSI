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
        //Caballeros de los que dispone el jugador
        //({x:Bind} al GridView de Caballeros)
        private ObservableCollection<Knight> Knights { get; set; } = new ObservableCollection<Knight>();
        //Habilidades del caballero escogido
        //({x:Bind} al GridView de Habilidades)
        private ObservableCollection<Skill> Skills { get; set; } = new ObservableCollection<Skill>();
        //Habilidades EQUIPADAS del caballero escogido
        private List<Skill> SelectedSkills { get; set; } = new List<Skill>();
        //Imagenes de las habiliades del caballero escogido
        private List<Image> SelectedSkillsImages { get; set; } = new List<Image>();

        Skill skill = null; //Referencia a la habilidad seleccionada
        Image image = null; //Referencia a la imagen seleccionada
        int index = -1; //Indice de la habilidad del GridView seleccionada

        //Caballero seleccionado que actualiza propiedades de la escena con {x:Bind}
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
                    //Guardamos una copia de los caballeros disponibles
                    Knights.Add(new Knight(knight));
                }
            //Se obtiene una referencia a las imagenes de las habilidades
            InitializeSelectedSkillsImages();
            //El Caballero seleccionado es el primero por defecto
            selectedKnight.Add(Knights[0]);
            SelectKnight(Knights[0]);

            base.OnNavigatedTo(e);
        }

        //Metodo que guarda una referencia a las imagenes de las habilidades para poder cambiarlas por codigo
        private void InitializeSelectedSkillsImages()
        {
            SelectedSkillsImages.Add(SelectedSkillImage1);
            SelectedSkillsImages.Add(SelectedSkillImage2);
            SelectedSkillsImages.Add(SelectedSkillImage3);
        }

        private void KnightSelection(object sender, ItemClickEventArgs e)
        {
            Sounds.playSound("button.wav");
            Knight k = e.ClickedItem as Knight;
            SelectKnight(k);
        }

        private void SelectKnight(Knight knight)
        {
            Sounds.playSound("button.wav");
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
            Sounds.playSound("button.wav");

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
                //Se actualiza el source del modelo de datos
                skill.EquipAbility();
                //Si hay un hueco libre
                int nextFreeSkillIndex = selectedKnight[0].EquipedAbilities.Count;
                //Se añade la habilidad a la interfaz
                SelectedSkills.Add(skill);
                selectedKnight[0].EquipedAbilities.Add(skill);
                //Se carga de nuevo con el Source
                SelectedSkillsImages[nextFreeSkillIndex].Source = new BitmapImage(new Uri(skill.ImageSource));
                image.Source = new BitmapImage(new Uri(skill.ImageSource));
                UpdateSelectedSkills();
            }
        }

        //Metodo para desequpar una habilidad en el Caballero selecionado
        private void UnequipAbility(Skill skill, Image image)
        {
            //Si encontramos la habilidad dentro de las equipadas...
            for (int i = 0; i < selectedKnight[0].EquipedAbilities.Count; i++)
            {
                if (SelectedSkills[i] == skill)
                {
                    //Se actualiza el source del modelo de datos
                    skill.UnequipAbility();
                    //Se elimina de la interfaz
                    SelectedSkills.RemoveAt(i);
                    selectedKnight[0].EquipedAbilities.RemoveAt(i);
                    //Se carga de nuevo la imagen con el source 
                    SelectedSkillsImages[i].Source = new BitmapImage(new Uri("ms-appx:///Assets/skills/skill_not_used.png"));
                    image.Source = new BitmapImage(new Uri(skill.ImageSource));
                    UpdateSelectedSkills();
                    break;
                }
            }
        }

        //Metodo que rellena las habilidades escogidas del Caballero en la interfaz (en SelectedSkills)
        private void UpdateSelectedSkills()
        {
            //Se eliminan las anteriores
            SelectedSkills.Clear();
            int i = 0;
            //Se incluyen las habilidades equipadas
            while (i < selectedKnight[0].EquipedAbilities.Count)
            {
                SelectedSkills.Add(selectedKnight[0].EquipedAbilities[i]);
                SelectedSkillsImages[i].Source = new BitmapImage(new Uri(selectedKnight[0].EquipedAbilities[i].ImageSource));
                i++;
            }
            //Si el numero de habilidades que tenia el Caballero es menor que el maximo
            while (i < Knight.MAX_HABILITES)
            {
                //Se rellenan los huecos vacios con imagenes de "habilidad no equipada"
                SelectedSkillsImages[i].Source = new BitmapImage(new Uri("ms-appx:///Assets/skills/skill_not_used.png"));
                i++;
            }
        }

        //Metodo llamado cuando se cancela una seleccion en la caja de confirmacion
        private void No_Click(object sender, RoutedEventArgs e)
        {
            Sounds.playSound("deny_sound.wav");
            //Se esconde la caja de confirmacion de seleccion
            FalseBackground.Visibility = Visibility.Collapsed;
            ConfirmBox.Visibility = Visibility.Collapsed;
        }

        //Metodo llamado cuando se confirma una seleccion en la caja de confirmacion
        //3 casos para la habilidad seleccionada (Bloqueada, Equipada, No equipada)
        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            Sounds.playSound("confirm_sound.wav");
            //Bloqueada?
            if (!skill.IsUnlocked) UnlockAbility(skill, index, image);
            else
            {
                //Equipada?
                if (skill.IsActive) UnequipAbility(skill, image);
                //No equipada?
                else EquipAbility(skill, image);
            }

            //Se deselecciona la habilidad escogida
            skill = null;
            image = null;
            index = -1;

            //Se esconde la caja de confirmacion de seleccion
            FalseBackground.Visibility = Visibility.Collapsed;
            ConfirmBox.Visibility = Visibility.Collapsed;
        }

        //Metodo que partiendo de un elemento root encuentra un hijo con nombre name
        //(Usado principalmente para acceder a elememtos de un DataTemplate por codigo)
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

        //Metodos para salir de la pagina
        private void GoBack(object sender, RoutedEventArgs e)
        {
            Sounds.playSound("button.wav");
            //Actualizamos los Caballeros disponilbes con los nuevos cambios hechos en esta interfaz
            AvailableKnights.UpdateAvailableKnights(Knights.ToList());
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
            }
        }

        private void GoToMainMenu(object sender, RoutedEventArgs e)
        {
            Sounds.playSound("button.wav");
            //Actualizamos los Caballeros disponilbes con los nuevos cambios hechos en esta interfaz
            AvailableKnights.UpdateAvailableKnights(Knights.ToList());
            while (this.Frame.CanGoBack)
                Frame.GoBack();
        }

        private void GoToSettings(object sender, RoutedEventArgs e)
        {
            Sounds.playSound("button.wav");
            //Actualizamos los Caballeros disponilbes con los nuevos cambios hechos en esta interfaz
            AvailableKnights.UpdateAvailableKnights(Knights.ToList());
            Frame.Navigate(typeof(Opciones));
        }

        private void Grid_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Sounds.playSound("button.wav");
            //Actualizamos los Caballeros disponilbes con los nuevos cambios hechos en esta interfaz
            AvailableKnights.UpdateAvailableKnights(Knights.ToList());
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
