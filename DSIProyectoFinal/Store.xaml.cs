using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Media.Imaging;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace DSIProyectoFinal
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Store : Page
    {
        private ObservableCollection<Knight> Knights { get; set; } = new ObservableCollection<Knight>();
        private List<bool> Buyable { get; } = new List<bool>();
        int index = -1;
        private Image imageSoldReference;
        public Store()
        {
            this.InitializeComponent();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {

            if (Knights != null)
                foreach (Knight knight in StoreKnights.GetStoreKnights())
                {
                    Knights.Add(new Knight(knight));
                    if (knight.Bought == Visibility.Visible) Buyable.Add(false);
                    else Buyable.Add(true);
                }

            Money.Text = StoreKnights.Prize.ToString();

            base.OnNavigatedTo(e);
        }

        private void GoBackPage(object sender, RoutedEventArgs e)
        {
            Sounds.playSound("button.wav");
            if (Frame.CanGoBack)
            {
                StoreKnights.UpdateStoreKnights(Knights.ToList());
                StoreKnights.Prize = int.Parse(Money.Text);
                Frame.GoBack();
            }
        }

        private void GoToMainMenu(object sender, RoutedEventArgs e)
        {
            Sounds.playSound("button.wav");
            StoreKnights.UpdateStoreKnights(Knights.ToList());
            StoreKnights.Prize = int.Parse(Money.Text);
            while (this.Frame.CanGoBack)
                Frame.GoBack();
        }

        private void GoToSettings(object sender, RoutedEventArgs e)
        {
            Sounds.playSound("button.wav");
            StoreKnights.UpdateStoreKnights(Knights.ToList());
            StoreKnights.Prize = int.Parse(Money.Text);
            Frame.Navigate(typeof(Opciones));
        }

        public void GridPurchase_ItemClick(object sender, ItemClickEventArgs e)
        {
            Sounds.playSound("button.wav");
            index = Knights.IndexOf((Knight)e.ClickedItem);

            if (Buyable[index])
            {
                (sender as GridView).SelectedIndex = index;

                FalseBackground.Visibility = Visibility.Visible;
                ConfirmBox.Visibility = Visibility.Visible;

                GridViewItem gridViewItem = (GridViewItem)this.GridPurchase.ContainerFromIndex(index);
                if (gridViewItem != null) imageSoldReference = (FindByName("Sold", gridViewItem) as Image);
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Sounds.playSound("button.wav");

            // Get the instance of ComboBox
            ComboBox comboBox = sender as ComboBox;

            // Get the ComboBox selected item text
            string selectedItem = comboBox.SelectedItem.ToString();

            switch (selectedItem)
            {
                //case "Order by Price":
                //    object x = new ObservableCollection<Knight>(Knights.OrderBy(s => s.ShopCost).ToList());
                //    Knights = x as ObservableCollection<Knight>;
                //    break;
                //case "Order by Alphabetical":
                //    Knights = new ObservableCollection<Knight>(Knights.OrderBy(s => s.Name).ToList());
                //    break;
                default:
                    break;
            }
        }

        private void ConfirmBuy_Click(object sender, RoutedEventArgs e)
        {
            Sounds.playSound("confirm_sound.wav");

            FalseBackground.Visibility = Visibility.Collapsed;
            ConfirmBox.Visibility = Visibility.Collapsed;

            int newMoney = int.Parse(Money.Text) - Knights[index].ShopCost;

            Money.Text = newMoney.ToString();
            Knights[index].Bought = Visibility.Visible;
            AvailableKnights.AddAvailableKnight(Knights[index]);
            Buyable[index] = false;
            if (imageSoldReference != null) imageSoldReference.Visibility = Visibility.Visible;

            index = -1;
        }

        private void CancelBuy_Click(object sender, RoutedEventArgs e)
        {
            Sounds.playSound("deny_sound.wav");
            FalseBackground.Visibility = Visibility.Collapsed;
            ConfirmBox.Visibility = Visibility.Collapsed;

            index = -1;
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
