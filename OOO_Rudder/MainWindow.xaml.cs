using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using System.Data.SqlClient;

namespace OOO_Rudder
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        public List<UserRole> UserRoles = RudderEntities.GetContext().UserRole.ToList();
        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        { }

        private void BtnEnter_Click_1(object sender, RoutedEventArgs e)
        {
            if (LogTB.Text == null || PassTB.Text == null)
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                foreach (var user in UserRoles)
                {
                    if (user.UserPasswords == PassTB.Text.ToString() && user.UserLogin == LogTB.Text.ToString())
                    {
                        MessageBox.Show($"Добро пожаловать, {user.UserName}!");
                        Store store = new Store();
                        store.Show();
                        return;
                    }
                    else if (user.ID == UserRoles.Count)
                    {
                        MessageBox.Show($"Неверные данные!");
                        return;
                    }
                }
            }
        }
    }
}
