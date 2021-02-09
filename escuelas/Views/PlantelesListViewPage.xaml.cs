using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using escuelas.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace escuelas.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlantelesListViewPage : ContentPage
    {
        

        public PlantelesListViewPage()
        {
            InitializeComponent();
            this.Title = "Planteles escolares";



        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            // ejemplo planteles funcionando

            var api = new escuelasApiService();

            var ListaEsucelas = api.getEscuelas();

            MyListView.ItemsSource = ListaEsucelas;
        }
    }
}
