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
            try
            {
                Company user = context.Company
                .ToList().Where(i => i.Login == LoginTxt.Text && i.Password == PasswTxt.Text)
                    .FirstOrDefault();
                if (user != null)
                {
                    classi.DataUser.Company = user;
                    Menu menu = new Menu();
                    this.Hide();
                    menu.ShowDialog();
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

        private void registr_Click(object sender, RoutedEventArgs e)
        {
            
            Registrat registrat = new Registrat();   
            this.Hide();
            registrat.ShowDialog();
         
        }

        private void help_Click(object sender, RoutedEventArgs e)
        {
            Help help = new Help();
            this.Hide();
            help.ShowDialog();
          
        }

        private void tehsupport_Click(object sender, RoutedEventArgs e)
        {
            Support support = new Support();
            this.Hide();
            support.ShowDialog();
           
        }
    }
}
