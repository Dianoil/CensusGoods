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
using static CensusGoods.classi.Enti;

namespace CensusGoods.Wind
{
    /// <summary>
    /// Логика взаимодействия для Autorization.xaml
    /// </summary>
    public partial class Autorization : Window
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void entry_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();

            //try
            //{
            //    Company user = context.Company
            //    .ToList().Where(i => i.Email == LoginTxt.Text &&  i.Password == PasswTxt.Password)
            //        .FirstOrDefault();
            //    if (user != null)
            //    {
            //        classi.DataUser.Company = user;
            //        //тут надо указать о роли чела
            //        Menu menu = new Menu();
            //        this.Hide();
            //        menu.ShowDialog();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Логин или пароль введены неверно");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        private void undo_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти из приложения?", "Выход", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
        //private void registr_Click(object sender, RoutedEventArgs e)
        //{
            
        //    Registrat registrat = new Registrat();   
        //    this.Hide();
        //    registrat.ShowDialog();
         
        //}

        //private void help_Click(object sender, RoutedEventArgs e)
        //{
        //    Help help = new Help();
        //    this.Hide();
        //    help.ShowDialog();
          
        //}

        //private void tehsupport_Click(object sender, RoutedEventArgs e)
        //{
        //    Support support = new Support();
        //    this.Hide();
        //    support.ShowDialog();
           
        //}
        private void vhodinsystem_Click(object sender, RoutedEventArgs e)
        {
            //if (LoginTxt.Text != null)
            //{
                stackepanele.Visibility = Visibility.Visible;
                EyeBut.Visibility = Visibility.Visible;
                PasswTxt.Visibility = Visibility.Visible;
                OutLogintxt.Content = LoginTxt.Text;
            //}
            //else
            //{
            //    MessageBox.Show("Введите логин", "Внимание!", MessageBoxButton.OKCancel, MessageBoxImage.Information);
            //}
        }

        private void EyeBut_Click(object sender, RoutedEventArgs e)
        {
            if (StackEye.Visibility == Visibility.Hidden)
            {
                PasswTxt.Visibility = Visibility.Hidden;
                StackEye.Visibility = Visibility.Visible;
                EyeBut.Visibility = Visibility.Hidden;
                PasswEye.Text = PasswTxt.Password;
                EyeBut1.Visibility = Visibility.Visible;
            }
        }

        private void EyeBut1_Click(object sender, RoutedEventArgs e)
        {
            if (StackEye.Visibility == Visibility.Visible)
            {
                PasswTxt.Visibility = Visibility.Visible;
                StackEye.Visibility = Visibility.Hidden;
                EyeBut.Visibility = Visibility.Visible;
                EyeBut1.Visibility = Visibility.Hidden;
                PasswTxt.Password = PasswEye.Text;
            }
        }

        private void OutLogintxt_Click(object sender, RoutedEventArgs e)
        {
            if (StackEye.Visibility == Visibility.Visible || stackepanele.Visibility == Visibility.Visible)
            {
                StackEye.Visibility = Visibility.Hidden;
                stackepanele.Visibility = Visibility.Hidden;
            }
        }

        private void question_Click(object sender, RoutedEventArgs e)
        {
            Support support = new Support();
            this.Close();
            support.ShowDialog();
        }
    }
}
