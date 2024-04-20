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

namespace Diplom
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DiplomosEntities2 entities = new DiplomosEntities2();
        public void newpol()
        {
            var newpols = new NewPolzovatil();
            newpols.Show();
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void entrance_Click(object sender, RoutedEventArgs e)
        {

            string Login = login.Text.Trim();
            string Password = password.Password.Trim();
            
            if (!string.IsNullOrEmpty(Login) ||
                !string.IsNullOrEmpty(Password))
            {

                List<Users> users = entities.Users.Where((user) => user.Password == Password && user.Login == Login).ToList();

                if (users.Any())
                {
                    var window_ = new main(users.First());
                    window_.Show();
                }
                else
                {
                    MessageBox.Show("Аутентификация", "Ошибка! Проверьте правильность данных!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                Close();
            }
            else
            {
                MessageBox.Show("Аутентификация", "Ошибка! Проверьте правильность данных!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void register_Click(object sender, RoutedEventArgs e)
        {
            newpol();
            Close();
        }
        
    }
}
