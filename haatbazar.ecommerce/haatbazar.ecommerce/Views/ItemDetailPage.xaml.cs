using HaatBazar.Ecommerce.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace HaatBazar.Ecommerce.Views
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