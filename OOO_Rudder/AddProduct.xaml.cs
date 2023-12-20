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
    /// Логика взаимодействия для AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    {
        public AddProduct()
        {
            InitializeComponent();
         
        }
        public List<Products> products = RudderEntities.GetContext().Products.ToList();
        public Products NewProduct = new Products();

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
          if (txtDiscr.Text == null || txtName.Text == null || txtManuf.Text == null || txtPrice.Text == null || txtSize.Text == null)
          {
                MessageBox.Show("Заполните все поля!");
                return;
          }
          else 
          { 
                NewProduct.Name = txtName.Text.ToString();
                NewProduct.Manufacturer = txtManuf.Text.ToString();
                NewProduct.Description = txtDiscr.Text.ToString();
                NewProduct.Price = int.Parse(txtPrice.Text.ToString());
                NewProduct.Size = txtSize.Text.ToString();
                NewProduct.Photo = null;
                RudderEntities.GetContext().Products.Add(NewProduct);
                RudderEntities.GetContext().SaveChanges();
                MessageBox.Show("Вы добавили новый продукт!");
            
          }


        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
