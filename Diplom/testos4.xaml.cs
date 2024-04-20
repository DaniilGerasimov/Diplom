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
    /// Логика взаимодействия для testos4.xaml
    /// </summary>
    public partial class testos4 : Window
    {
        DiplomosEntities2 entities = new DiplomosEntities2();
        int i = 0;
        Users User { get; set; }
        public testos4(Users user)
        {
            InitializeComponent();
            User = user;
            vopros2.IsEnabled = false;
            vopros3.IsEnabled = false;
            vopros4.IsEnabled = false;
            vopros5.IsEnabled = false;
        }
        public void testos()
        {
            var window_ = new Test(User);
            window_.Show();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            testos();
            Close();
        }
        public void vopros(Test1 Variant)
        {

            Voprosik_textbox.Text = Variant.Vopros;
            otvet1.Text = Variant.Var_otveta_1;
            otvet2.Text = Variant.Var_otveta_2;
            otvet3.Text = Variant.Var_otveta_3;
            otvet4.Text = Variant.Var_otveta_4;

        }
        public void Clears()
        {
            Voprosik_textbox.Text = "";
            otvet1.Text = "";
            otvet2.Text = "";
            otvet3.Text = "";
            otvet4.Text = "";
            prav_otvet.Text = "";
        }
        private void vopros1_Click(object sender, RoutedEventArgs e)
        {
            Clears();
            foreach (var Variant in entities.Test1)
            {

                if (Variant.Nomer_testa == 4 &&
                    Variant.Nomer_voprosa == 1)
                {
                    vopros(Variant);
                }
            }
            vopros1.IsEnabled = false;
            vopros2.IsEnabled = true;
        }

        private void vopros2_Click(object sender, RoutedEventArgs e)
        {
            if (prav_otvet.Text != null && prav_otvet.Text != "")
            {

                foreach (var Variant in entities.Test1)
                {

                    if (Variant.Nomer_testa == 4 && Variant.Nomer_voprosa == 1)
                    {
                        if (prav_otvet.Text == Variant.Prav_otvet)
                        {
                            i = i + 1;
                        }
                    }
                }
                Clears();
                foreach (var Variant in entities.Test1)
                {

                    if (Variant.Nomer_testa == 4 && Variant.Nomer_voprosa == 2)
                    {
                        vopros(Variant);

                    }
                }
                vopros2.IsEnabled = false;
                vopros3.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("Выберите 1 вариант ответа", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void vopros3_Click(object sender, RoutedEventArgs e)
        {
            if (prav_otvet.Text != null && prav_otvet.Text != "")
            {
                foreach (var Variant in entities.Test1)
                {

                    if (Variant.Nomer_testa == 4 && Variant.Nomer_voprosa == 2)
                    {
                        if (prav_otvet.Text == Variant.Prav_otvet)
                        {
                            i = i + 1;
                        }
                    }
                }
                Clears();
                foreach (var Variant in entities.Test1)
                {

                    if (Variant.Nomer_testa == 4 && Variant.Nomer_voprosa == 3)
                    {
                        vopros(Variant);

                    }
                }
                vopros3.IsEnabled = false;
                vopros4.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("Выберите 1 вариант ответа", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void vopros4_Click(object sender, RoutedEventArgs e)
        {
            if (prav_otvet.Text != null && prav_otvet.Text != "")
            {
                foreach (var Variant in entities.Test1)
                {

                    if (Variant.Nomer_testa == 4 && Variant.Nomer_voprosa == 3)
                    {
                        if (prav_otvet.Text == Variant.Prav_otvet)
                        {
                            i = i + 1;
                        }
                    }
                }
                Clears();
                foreach (var Variant in entities.Test1)
                {

                    if (Variant.Nomer_testa == 4 && Variant.Nomer_voprosa == 4)
                    {
                        vopros(Variant);

                    }
                }
                vopros4.IsEnabled = false;
                vopros5.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("Выберите 1 вариант ответа", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void vopros5_Click(object sender, RoutedEventArgs e)
        {
            if (prav_otvet.Text != null && prav_otvet.Text != "")
            {
                foreach (var Variant in entities.Test1)
                {

                    if (Variant.Nomer_testa == 4 && Variant.Nomer_voprosa == 4)
                    {
                        if (prav_otvet.Text == Variant.Prav_otvet)
                        {
                            i = i + 1;
                        }
                    }
                }
                prav_otvet.Text = "";
                foreach (var Variant in entities.Test1)
                {

                    if (Variant.Nomer_testa == 4 && Variant.Nomer_voprosa == 5)
                    {
                        vopros(Variant);

                    }
                }
                vopros5.IsEnabled = false;
            }
            else
            {
                MessageBox.Show("Выберите 1 вариант ответа", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void rezult_Click(object sender, RoutedEventArgs e)
        {
            if (prav_otvet.Text != null && prav_otvet.Text != "")
            {
                foreach (var Variant in entities.Test1)
                {

                    if (Variant.Nomer_testa == 4 && Variant.Nomer_voprosa == 5)
                    {
                        if (prav_otvet.Text == Variant.Prav_otvet)
                        {
                            i = i + 1;
                        }
                    }

                }
                Rezult rezult = new Rezult();
                if (i == 0 || i == 1 || i == 2)
                {

                    entities.Rezult.Add(rezult);
                    rezult.Nick = User.Nickneim;
                    rezult.Evaluation = 2;
                    rezult.Nomer_testa = 2;
                    entities.SaveChanges();
                    MessageBox.Show("Ваша оценка = 2");
                }
                if (i == 3)
                {
                    rezult.Nick = User.Nickneim;
                    rezult.Evaluation = 3;
                    rezult.Nomer_testa = 2;
                    entities.Rezult.Add(rezult);
                    entities.SaveChanges();
                    MessageBox.Show("Ваша оценка = " + i);
                }
                if (i == 4)
                {
                    rezult.Nick = User.Nickneim;
                    rezult.Evaluation = 4;
                    rezult.Nomer_testa = 2;
                    entities.Rezult.Add(rezult);
                    entities.SaveChanges();
                    MessageBox.Show("Ваша оценка = " + i);
                }
                if (i == 5)
                {
                    rezult.Nick = User.Nickneim;
                    rezult.Evaluation = 5;
                    rezult.Nomer_testa = 2;
                    entities.Rezult.Add(rezult);
                    entities.SaveChanges();
                    MessageBox.Show("Ваша оценка = " + i);
                }
            }
            else
            {
                MessageBox.Show("Выберите 1 вариант ответа", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
