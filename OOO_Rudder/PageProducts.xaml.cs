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

namespace OOO_Rudder
{
    /// <summary>
    /// Логика взаимодействия для PageProducts.xaml
    /// </summary>
    public partial class PageProducts : Page
    {
        public PageProducts()
        {
            InitializeComponent();
            DGProducts.ItemsSource = RudderEntities.GetContext().Products.ToList();
        }
    }
}
