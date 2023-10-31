using Microsoft.Maui.Controls;
using System;

namespace GIWA
{
    public partial class ProductDetailPage : ContentPage
    {
        public ProductDetailPage(Product product)
        {
            InitializeComponent();

            // Sätt produktinformationen på sidan
            ProductImage.Source = product.ImagePath;
            ProductNameLabel.Text = product.Name;
            ProductDescriptionLabel.Text = product.Description;

            // Visa låsknappen endast om produkten kan låsas
            LockButton.IsVisible = product.CanBeLocked;
        }

        private void OnLockButtonClicked(object sender, EventArgs e)
        {
            // Lås produkten här
            // Exempel:
            // product.IsLocked = true;
            // Uppdatera databasen eller andra källor med den nya statusen
        }
    }

    // Exempel på en produktklass
    public class Product
    {
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool CanBeLocked { get; set; }
    }
}
