using Microsoft.Maui.Controls;
using System;

namespace GIWA
{
    public partial class ProductDetailPage : ContentPage
    {
        public ProductDetailPage(Product product)
        {
            InitializeComponent();

            // S�tt produktinformationen p� sidan
            ProductImage.Source = product.ImagePath;
            ProductNameLabel.Text = product.Name;
            ProductDescriptionLabel.Text = product.Description;

            // Visa l�sknappen endast om produkten kan l�sas
            LockButton.IsVisible = product.CanBeLocked;
        }

        private void OnLockButtonClicked(object sender, EventArgs e)
        {
            // L�s produkten h�r
            // Exempel:
            // product.IsLocked = true;
            // Uppdatera databasen eller andra k�llor med den nya statusen
        }
    }

    // Exempel p� en produktklass
    public class Product
    {
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool CanBeLocked { get; set; }
    }
}
