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
    /// Interaction logic for KlantenControl.xaml
    /// </summary>
    public partial class KlantenControl : UserControl
    {
        DataBaseDataContext db = new DataBaseDataContext();
        public klant PublicKlant;
        public KlantenControl()
        {
            InitializeComponent();
            DGCustomers.ItemsSource = db.klants.ToList();
        }

        private void KlantUpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            if (PublicKlant != null)
            {
                PublicKlant.Naam = KlantNaamBox.Text;
                PublicKlant.Stad = KlantStadBox.Text;
                PublicKlant.MobielNummer = KlantMobielBox.Text;
                PublicKlant.EMail = KlantMailBox.Text;
                db.SubmitChanges();
            }
        }

        private void KlantOpslaanBtn_Click(object sender, RoutedEventArgs e)
        {
            klant DeKlant = new klant();
            DeKlant.Naam = KlantNaamBox.Text;
            DeKlant.Stad = KlantStadBox.Text;
            DeKlant.MobielNummer = KlantMobielBox.Text.ToString();
            DeKlant.EMail = KlantMailBox.Text;

            db.klants.InsertOnSubmit(DeKlant);

            db.SubmitChanges();

            DGCustomers.ItemsSource = db.klants.ToList();
        }

        private void btnVerwijderenKlant_Click_1(object sender, RoutedEventArgs e)
        {
            var item = (klant)DGCustomers.SelectedItem;

            MessageBoxResult mbr = MessageBox.Show("Weet u het zeker dat u " + item.Naam + " wilt verwijderen?", "Waarschuwing!", MessageBoxButton.YesNo);

            if (MessageBoxResult.Yes == mbr)
            {
                db.klants.DeleteOnSubmit(item);

                db.SubmitChanges();
                DGCustomers.ItemsSource = db.klants.ToList();
            }
        }

        private void DGCustomers_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = (klant)DGCustomers.SelectedItem;
            PublicKlant = item;
            KlantNaamBox.Text = item.Naam;
            KlantStadBox.Text = item.Stad;
            KlantMobielBox.Text = item.MobielNummer;
            KlantMailBox.Text = item.EMail;
        }
    }
}
