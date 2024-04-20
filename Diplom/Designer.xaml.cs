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
    /// Логика взаимодействия для Designer.xaml
    /// </summary>
    public partial class Designer : Window
    {
        Users User { get; set; }
        public Designer(Users user)
        {
            InitializeComponent();
            User = user;
            Uri CompiliatorUri = new Uri("https://rextester.com/");
            webBrowser.Navigate(CompiliatorUri);
        }

        public void mainos()
        {
            var window_ = new main(User);
            window_.Show();
        }
        public void testos()
        {
            var window_ = new Test(User);
            window_.Show();
        }
        public void lectureos()
        {
            var window_ = new Lecture(User);
            window_.Show();
        }
        public void profileos()
        {
            var window_ = new Profile(User);
            window_.Show();
        }

        private void mains_Click(object sender, RoutedEventArgs e)
        {
            mainos();
            Close();
        }

        private void tests_Click(object sender, RoutedEventArgs e)
        {
            testos();
            Close();
        }

        private void lecture_Click(object sender, RoutedEventArgs e)
        {
            lectureos();
            Close();
        }

        private void profile_Click(object sender, RoutedEventArgs e)
        {
            profileos();
            Close();
        }
    }
}
