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
    /// Interaction logic for BestelControl.xaml
    /// </summary>
    public partial class BestelControl : UserControl
    {
        DataBaseDataContext db = new DataBaseDataContext();
        public BestelControl()
        {
            InitializeComponent();
            DGProduct.ItemsSource = db.products.ToList();
            NaamSelectorCMB.ItemsSource = db.klants.ToList();
        }

        private void DGProduct_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = DGProduct.SelectedItem;
            if (item != null)
            {
                product hetItem = (product)item;
                DGBestelling.Items.Add(hetItem);
            }
        }

        private void BestelBtn_Click(object sender, RoutedEventArgs e)
        {
            var deKlant = (klant)NaamSelectorCMB.SelectedItem;
            Item bestel = new Item();
            bestel.bestellingen = new bestellingen();
            //koppelen klant aan bestelling
            bestel.bestellingen.klant = deKlant;
            bestel.Hoeveelheid = HoeveelheidBox.Text;
            ItemCollection ic = DGBestelling.Items;
            foreach (var i in ic)
            {
                bestel.product = (product)i;
                db.Items.InsertOnSubmit(bestel);
            }
            db.SubmitChanges();
        }
    }
}
