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

namespace Diplom
{
    /// <summary>
    /// Логика взаимодействия для NewPolzovatil.xaml
    /// </summary>
    public partial class NewPolzovatil : Window
    {
        DiplomosEntities2 entities = new DiplomosEntities2();

        public NewPolzovatil()
        {
            InitializeComponent();
        }
        public void mainwindow() 
        {
            var windows = new MainWindow();
            windows.Show();
        }
        private void NewPolzov_Click(object sender, RoutedEventArgs e)
        {
            string m_aut = "Аутентификация";
            string m_errorincor = "Ошибка! Проверьте правильность данных!";
            if (Lodins.Text != "" && Lodins.Text == null ||
                passBox1.Password != "" && passBox1.Password != null ||
                passBox2.Password != "" && passBox2.Password != null ||
                Nikcneim.Text !="" && Nikcneim.Text != null ||
                mail.Text !="" && mail.Text != null)
            {
                string Login = Lodins.Text;
                string Password = passBox1.Password;
                string Password2 = passBox2.Password;

                foreach (var login1 in entities.Users)
                {
                    if (Login == login1.Login)
                    {
                        MessageBox.Show("Пользователь с данным логином уже существует!",
                            "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                        return;
                    }
                }
                try
                {
                    if (passBox1.Password == passBox2.Password)
                    {
                        Users users = new Users();
                        {
                            users.Login = Lodins.Text;
                            users.Password = passBox1.Password.ToString();
                            users.Nickneim = Nikcneim.Text;
                            users.Mail = mail.Text;
                        };

                        entities.Users.Add(users);
                        entities.SaveChanges();
                        MessageBox.Show("Данные успешно добавлены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                        mainwindow();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Проверьте правильность введенных данных!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }


                catch
                {
                    MessageBox.Show("Ошибка при добавлении данных!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                }

            }
            else
                MessageBox.Show(m_errorincor, m_aut, MessageBoxButton.OK, MessageBoxImage.Error);
        }

    }
}
