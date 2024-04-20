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
using System.IO;
using Microsoft.Win32;
using System.Windows.Xps.Packaging;
using Microsoft.Office.Interop.Word;

namespace Diplom
{
    /// <summary>
    /// Логика взаимодействия для Lecture.xaml
    /// </summary>
    public partial class Lecture : System.Windows.Window
    {
        DiplomosEntities2 entities = new DiplomosEntities2 ();
        Users User { get; set; }
        
        public Lecture(Users user)
        {
            User = user;
            InitializeComponent();
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
            designeros();
            Close();
        }

        private void profile_Click(object sender, RoutedEventArgs e)
        {
            profileos();
            Close();
        }
        private void lecture5_Click(object sender, RoutedEventArgs e)
        {
            var selected_Link = (from lectr in entities.FullLecture
                                 where lectr.Nomer_Lecture == 5
                                 select lectr.Link).Single<String>();
            Uri lectureUri = new Uri(selected_Link);
            webBrowser.Navigate(lectureUri);
        }

        private void Lecture1_Click(object sender, RoutedEventArgs e)
        {
            var selected_Link = (from lectr in entities.FullLecture
                                 where lectr.Nomer_Lecture == 1
                                 select lectr.Link).Single<String>();
            Uri lectureUri = new Uri(selected_Link);
            webBrowser.Navigate(lectureUri);
        }

        private void lecture2_Click(object sender, RoutedEventArgs e)
        {
            var selected_Link = (from lectr in entities.FullLecture
                                 where lectr.Nomer_Lecture == 2
                                 select lectr.Link).Single<String>();
            Uri lectureUri = new Uri(selected_Link);
            webBrowser.Navigate(lectureUri);
        }

        private void lecture3_Click(object sender, RoutedEventArgs e)
        {
            var selected_Link = (from lectr in entities.FullLecture
                           where lectr.Nomer_Lecture == 3
                           select lectr.Link).Single<String>() ;
            Uri lectureUri = new Uri(selected_Link);
            webBrowser.Navigate(lectureUri);
        }

        private void lecture4_Click(object sender, RoutedEventArgs e)
        {
            var selected_Link = (from lectr in entities.FullLecture
                                 where lectr.Nomer_Lecture == 4
                                 select lectr.Link).Single<String>();
            Uri lectureUri = new Uri(selected_Link);
            webBrowser.Navigate(lectureUri);
        }
    }
}
