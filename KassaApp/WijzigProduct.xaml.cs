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
using System.Windows.Shapes;

namespace KassaApp
{
    /// <summary>
    /// Interaction logic for WijzigProduct.xaml
    /// </summary>
    public partial class WijzigProduct : Window
    {
        private DataBaseDataContext db;
        ProductControl nwWindow;
        public WijzigProduct(ProductControl productControl, DataBaseDataContext db)
        {
            this.db = db;
            nwWindow = productControl;
            InitializeComponent();
            DGProductenSelector.ItemsSource = db.products.ToList();

        }


        private void DGProductenSelector_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = (product)DGProductenSelector.SelectedItem;
            nwWindow.PublicProduct = item;
            nwWindow.ProductNaamBox.Text = item.ProductNaam;
            nwWindow.ProductPrijsBox.Text = item.Prijs.ToString();
            this.Close();
        }
    }
}
