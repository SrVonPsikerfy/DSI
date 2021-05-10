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
        private ObservableCollection<Knights> knights { get; } = new ObservableCollection<Knights>();

        public Store()
        {
            this.InitializeComponent();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                bool[] abilities = { true, false, true };
                int[] pickedAbilities = { 1, 2, 3 };
                knights.Add(new Knights("Knight", "Assets/Imagen.png", "Rol", 5, 6, 7, 8, 9, 10, 1, 69, 210, 420, 21, abilities, pickedAbilities));
            }
            // Remove this when replaced with XAML bindings
            GridPurchase.ItemsSource = knights;

            base.OnNavigatedTo(e);
        }
    }
}
