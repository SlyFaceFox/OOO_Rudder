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

namespace OOO_Rudder
{
    /// <summary>
    /// Логика взаимодействия для Store.xaml
    /// </summary>
    public partial class Store : Window
    {
        public Store()
        {
            InitializeComponent();
            Main.Navigate(new PageProducts());
        }

        private void btnR_Click(object sender, RoutedEventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
        }
    }
}
