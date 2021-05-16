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
        private ObservableCollection<Knight> Knights { get; } = new ObservableCollection<Knight>();
        private List<bool> Buyable { get; } = new List<bool>();

        public Store()
        {
            this.InitializeComponent();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (Knights != null)
                foreach (Tuple<Knight, bool> knight in StoreKnights.GetStoreKnights())
                {
                    Tuple<Knight, bool> storeKnight = new Tuple<Knight, bool>(new Knight(knight.Item1), knight.Item2);
                    Knights.Add(storeKnight.Item1);
                    Buyable.Add(storeKnight.Item2);
                }
            //// Remove this when replaced with XAML bindings
            //GridPurchase.ItemsSource = Knights;

            base.OnNavigatedTo(e);
        }
        private void GoBack(object sender, RoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
            {
                List<Tuple<Knight, bool>> NewList = new List<Tuple<Knight, bool>>();

                for(int i = 0; i < Knights.Count(); i++)
                    NewList.Add(new Tuple<Knight, bool>(Knights[i], Buyable[i]));

                StoreKnights.UpdateKnights(NewList);
                this.Frame.GoBack();
            }
        }

        private void GoToMainMenu(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainMenu));
        }

        private void GoToSettings(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Opciones));
        }

    }
}
