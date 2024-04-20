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
    /// Логика взаимодействия для Profile.xaml
    /// </summary>
    public partial class Profile : Window
    {
        DiplomosEntities2 entities = new DiplomosEntities2();
        Users User { get; set; }
        public Profile(Users user)
        {
            InitializeComponent();
            User = user;
            nicks.Content = user.Nickneim;
            var selected = from rezults in entities.Rezult
                           where rezults.Nick==user.Nickneim
                           select new
                           {
                               Nick = rezults.Nick,
                               Nomer_testa = "Тест " + rezults.Nomer_testa,
                               Evaluation = rezults.Evaluation
                           };
            Rezults.ItemsSource = selected.ToList();
            var selecteds = from rezults in entities.Rezult
                           where rezults.Nick == user.Nickneim && rezults.Evaluation >= 4
                           select new
                           {
                               Nick = rezults.Nick,
                               Nomer_testa = "Тест " + rezults.Nomer_testa,
                               Evaluation = rezults.Evaluation
                           };
            RezultsTop.ItemsSource = selecteds.ToList();

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
        public void designereos()
        {
            var window_ = new Designer(User);
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
           
        }

        private void designer_Click(object sender, RoutedEventArgs e)
        {
            designereos();
            Close();
        }

        private void profile_Click(object sender, RoutedEventArgs e)
        {
            designereos();
            Close();
        }
    }
}
