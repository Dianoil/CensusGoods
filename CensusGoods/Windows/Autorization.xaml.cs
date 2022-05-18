using CensusGoods.EF;
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
using static CensusGoods.Class.Enti;
using static CensusGoods.Class.DataUser;
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
            try
            {
                User user = CensGoodsEnt.User
                .ToList().Where(i => i.login == LoginTxt.Text && i.password == PasswTxt.Password)
                    .FirstOrDefault();
                if (user != null)
                {
                    Class.DataUser.User1 = user;
                    if (Class.DataUser.User1.idRole == 4)
                	{

                        Menu menu = new Menu();
                        menu.FunctionAdmin.Visibility = Visibility.Visible;
                        this.Hide();
                        menu.ShowDialog();
                	}
                    else if (Class.DataUser.User1.idRole == 3)
                    {
                        Menu menu = new Menu();
                        menu.FunctionMainGoods.Visibility = Visibility.Visible;
                        this.Hide();
                        menu.ShowDialog();

                    }
                    else if (Class.DataUser.User1.idRole == 2)
                    {
                        Menu menu = new Menu();
                        menu.FunctionMainCompany.Visibility = Visibility.Visible;
                        this.Hide();
                        menu.ShowDialog();
                    }
                    else if (Class.DataUser.User1.idRole == 1)
                    {
                        Menu menu = new Menu();
                        menu.FuntionEmployee.Visibility = Visibility.Visible;
                        this.Hide();
                        menu.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Логин или пароль введены неверно");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void undo_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти из приложения?", "Выход", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
        private void vhodinsystem_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTxt.Text is null)
            {
                MessageBox.Show("Введите логин", "Внимание!", MessageBoxButton.OKCancel, MessageBoxImage.Information);
            }
            else
            {
                stackepanele.Visibility = Visibility.Visible;
                EyeBut.Visibility = Visibility.Visible;
                PasswTxt.Visibility = Visibility.Visible;
                OutLogintxt.Content = LoginTxt.Text;
            }
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
