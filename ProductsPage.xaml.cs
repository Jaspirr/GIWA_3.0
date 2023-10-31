using Microsoft.Maui.Controls;
using System;

namespace GIWA
{
    public partial class ProductsPage : ContentPage
    {
        public ProductsPage()
        {
            InitializeComponent();
        }

        private void OnProductTapped(object sender, EventArgs e)
        {
            // Navigera till produktdetaljsidan eller visa produktinformation
            // Exempel:
            // Navigation.PushAsync(new ProductDetailPage());
        }
       
        private void OnProductCardTapped(object sender, EventArgs e)
        {
            var selectedProduct = (Product)((BindableObject)sender).BindingContext;
            var detailPage = new ProductDetailPage(selectedProduct);
            this.Navigation.PushAsync(detailPage);
        }
    }
}
