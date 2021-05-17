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
            if (Frame.CanGoBack)
            {
                StoreKnights.UpdateKnights(Knights.ToList());
                StoreKnights.Prize = int.Parse(Money.Text);
                Frame.GoBack();
            }
        }

        private void GoToMainMenu(object sender, RoutedEventArgs e)
        {
            StoreKnights.UpdateKnights(Knights.ToList());
            StoreKnights.Prize = int.Parse(Money.Text);
            Frame.GoBack();
        }

        private void GoToSettings(object sender, RoutedEventArgs e)
        {
            StoreKnights.UpdateKnights(Knights.ToList());
            StoreKnights.Prize = int.Parse(Money.Text);
            Frame.Navigate(typeof(Opciones));
        }

        public void GridPurchase_ItemClick(object sender, ItemClickEventArgs e)
        {
            index = Knights.IndexOf((Knight)e.ClickedItem);

            if (Buyable[index])
            {
                (sender as GridView).SelectedIndex = index;

                FalseBackground.Visibility = Visibility.Visible;
                ConfirmBox.Visibility = Visibility.Visible;
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Get the instance of ComboBox
            ComboBox comboBox = sender as ComboBox;

            // Get the ComboBox selected item text
            string selectedItem = comboBox.SelectedItem.ToString();

            switch (selectedItem)
            {
                case "Order by Price":
                    object x = new ObservableCollection<Knight>(Knights.OrderBy(s => s.ShopCost).ToList());
                    Knights = x as ObservableCollection<Knight>;
                    break;
                case "Order by Alphabetical":
                    Knights = new ObservableCollection<Knight>(Knights.OrderBy(s => s.Name).ToList());
                    break;
                default:
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FalseBackground.Visibility = Visibility.Collapsed;
            ConfirmBox.Visibility = Visibility.Collapsed;

            int newMoney = int.Parse(Money.Text) - Knights[index].ShopCost;
            Money.Text = newMoney.ToString();
            Knights[index].Bought = Visibility.Visible;
            Buyable[index] = false;
            index = -1;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FalseBackground.Visibility = Visibility.Collapsed;
            ConfirmBox.Visibility = Visibility.Collapsed;

            index = -1;
        }
    }
}
