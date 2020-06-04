using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KassaApp
{
    /// <summary>
    /// Interaction logic for ProductControl.xaml
    /// </summary>
    public partial class ProductControl : UserControl
    {
        DataBaseDataContext db = new DataBaseDataContext();
        public product PublicProduct;
        public ProductControl()
        {
            InitializeComponent();
            DGProducts.ItemsSource = db.products.ToList();
            ProductPlaatjeComboBox.Items.Add("Pictures/bier.jpg");
            ProductPlaatjeComboBox.Items.Add("Pictures/frisdranken.png");
            ProductPlaatjeComboBox.Items.Add("Pictures/pizza.png");
            ProductPlaatjeComboBox.Items.Add("Pictures/friet.jpg");
            ProductPlaatjeComboBox.Items.Add("Pictures/misc.png");
        }

        private void ProductToevoegenBtn_Click(object sender, RoutedEventArgs e)
        {
            product HetProduct = new product();
            HetProduct.ProductNaam = ProductNaamBox.Text;
            HetProduct.Afbeelding = ProductPlaatjeComboBox.Text;
            HetProduct.Prijs = decimal.Parse(ProductPrijsBox.Text);

            producttypen DeOmschrijving = new producttypen();
            DeOmschrijving.Omschrijving = ProductBeschrijvingBox.Text;

            HetProduct.producttypen = DeOmschrijving;
            //Dat in de wachtrijzetten op opgeslagen te worden
            db.products.InsertOnSubmit(HetProduct);
            //Daadwerkelijk opslaan
            db.SubmitChanges();

            DGProducts.ItemsSource = db.products.ToList();
        }

        private void ProductenSelectie_Click(object sender, RoutedEventArgs e)
        {
            WijzigProduct wijzigProduct = new WijzigProduct(this, db);
            wijzigProduct.Show();
        }

        private void ProductUpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            if (PublicProduct != null)
            {
                PublicProduct.ProductNaam = ProductNaamBox.Text;
                PublicProduct.Prijs = decimal.Parse(ProductPrijsBox.Text.ToString());
                PublicProduct.Afbeelding = ProductPlaatjeComboBox.Text;
                db.SubmitChanges();
            }
        }

        private void btnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            var item = (product)DGProducts.SelectedItem;

            MessageBoxResult mbr = MessageBox.Show("Weet u het zeker dat u " + item.ProductNaam + " wilt verwijderen?", "Waarschuwing!", MessageBoxButton.YesNo);

            if (MessageBoxResult.Yes == mbr)
            {
                db.products.DeleteOnSubmit(item);

                db.SubmitChanges();
                DGProducts.ItemsSource = db.products.ToList();
            }
        }
    }
}
