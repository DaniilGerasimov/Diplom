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
    /// Логика взаимодействия для main.xaml
    /// </summary>
    public partial class main : Window
    {
        Users User { get; set; }

        public void lectureos()
        {
            var window_ = new Lecture(User);
            window_.Show();
        }
        public void testos()
        {
            var window_ = new Test(User);
            window_.Show();
        }
        public void designeros()
        {
            var window_ = new Designer(User);
            window_.Show();
        }
        public void profileos()
        {
            var window_ = new Profile(User);
            window_.Show();
        }
        public main( Users user)
        {
            InitializeComponent();
            User = user;
        }

        private void lecture_Click(object sender, RoutedEventArgs e)
        {
           lectureos();
            Close();
        }

        private void tests_Click(object sender, RoutedEventArgs e)
        {
            testos();
            Close();
        }

        private void designer_Click(object sender, RoutedEventArgs e)
        {
            designeros();
            Close();
        }

        private void profile_Click(object sender, RoutedEventArgs e)
        {
            profileos();
            Close();
        }
    }
}
