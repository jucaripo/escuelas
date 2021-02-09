using System.ComponentModel;
using Xamarin.Forms;
using escuelas.ViewModels;

namespace escuelas.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}