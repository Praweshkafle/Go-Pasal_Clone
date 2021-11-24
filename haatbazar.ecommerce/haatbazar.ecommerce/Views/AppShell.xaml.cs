using haatbazar.ecommerce.ViewModels;
using haatbazar.ecommerce.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace haatbazar.ecommerce
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
