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
    /// Логика взаимодействия для Test.xaml
    /// </summary>
    public partial class Test : Window
    {
        Users User { get; set; }
        public Test(Users user)
        {
            InitializeComponent();
            User = user;
        }

        public void mainos()
        {
            var window_ = new main(User);
            window_.Show();
        }
        public void lectureos()
        {
            var window_ = new Lecture(User);
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
        private void lecture_Click(object sender, RoutedEventArgs e)
        {
            lectureos();
            Close();
        }

        private void tests_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mains_Click(object sender, RoutedEventArgs e)
        {
            mainos();
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

       
        public void tests1()
        {
            var window_ = new testos1(User);
            window_.Show();
        }
        public void tests2()
        {
            var window_ = new testos2(User);
            window_.Show();
        }
        public void tests3()
        {
            var window_ = new testos3(User);
            window_.Show();

        }
        public void tests4()
        {
            var window_ = new testos4(User);
            window_.Show();
        }

        public void tests5()
        {
            var window_ = new testos5(User);
            window_.Show();
        }
        private void testik1_Click(object sender, RoutedEventArgs e)
        {
            tests1();
            Close();
        }

        private void testik2_Click(object sender, RoutedEventArgs e)
        {
            tests2();
            Close();
        }

        private void testik3_Click(object sender, RoutedEventArgs e)
        {
            tests3();
            Close();
        }

        private void testik4_Click(object sender, RoutedEventArgs e)
        {
            tests4();
            Close();
        }

        private void testik5_Click(object sender, RoutedEventArgs e)
        {
            tests5();
            Close();
        }
    }
}
