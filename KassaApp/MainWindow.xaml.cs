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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataBaseDataContext db = new DataBaseDataContext();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            MenuContent.Children.Clear();
        }

        private void BestelBtn_Click(object sender, RoutedEventArgs e)
        {
            BestelControl mw = new BestelControl();
            MenuContent.Children.Clear();
            MenuContent.Children.Add(mw);
        }

        private void ProductBtn_Click(object sender, RoutedEventArgs e)
        {
            ProductControl mw = new ProductControl();
            MenuContent.Children.Clear();
            MenuContent.Children.Add(mw);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            KlantenControl mw = new KlantenControl();
            MenuContent.Children.Clear();
            MenuContent.Children.Add(mw);
        }
    }
}
