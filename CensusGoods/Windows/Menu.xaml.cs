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
using CensusGoods.Pages;

namespace CensusGoods.Wind
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
            useracc.Content = $" {User.login}";

            if (Class.DataUser.User.idRole == 4)
            {
                FrameMenu.Navigate(new PageWatchDirectoryGoods());
            }
            else if (Class.DataUser.User.idRole == 3)
            {
                FrameMenu.Navigate(new PageDirectoryGoods());
            }
            else if (Class.DataUser.User.idRole == 2)
            {
                FrameMenu.Navigate(new PageReceipt());
            }
            else if (Class.DataUser.User.idRole == 1)
            {
                FrameMenu.Navigate(new PageInfoContainer());
            }
        }
        private void useracc_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).ContextMenu.IsEnabled = true;
            (sender as Button).ContextMenu.PlacementTarget = (sender as Button);
            (sender as Button).ContextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
            (sender as Button).ContextMenu.IsOpen = true;
        }

        private void undo_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти из приложения?", "Выход", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
        private void ExitProdile_Click(object sender, RoutedEventArgs e)
        {
            Autorization auth = new Autorization();
            this.Close();
            auth.ShowDialog();

        }

        #region Admin
        private void WatchDirectoryGoods_Click(object sender, RoutedEventArgs e)
        {
            FrameMenu.Navigate(new Pages.PageWatchDirectoryGoods());
        }
        private void Lk_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.IsEnabled = false;
            Windows.AddInfo registrat = new Windows.AddInfo();
            registrat.AddDirectoryGoods.Visibility = Visibility.Visible;
            registrat.ShowDialog();

        }
        private void tariffAdd_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.IsEnabled = false;
            Windows.AddInfo registrat = new Windows.AddInfo();
            registrat.AddTariff.Visibility = Visibility.Visible;
            registrat.ShowDialog();
        }

        #endregion


        #region DirectGoods
        private void companyadd_Click_1(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.IsEnabled = false;
            Windows.AddInfo registrat = new Windows.AddInfo();
            registrat.addInfoCompany.Visibility = Visibility.Visible;
            registrat.ShowDialog();

        }


        private void companyAdd_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.IsEnabled = false;
            Windows.AddInfo registrat = new Windows.AddInfo();
            registrat.AddDirectoryCompany.Visibility = Visibility.Visible;
            registrat.ShowDialog();

        }

        private void watchCompanyInfo_Click(object sender, RoutedEventArgs e)
        {
            FrameMenu.Navigate(new Pages.PageDirectoryGoods());
        }

        #endregion

        #region DirectoryCompany
        private void watchReceipt_Click(object sender, RoutedEventArgs e)
        {
            FrameMenu.Navigate(new Pages.PageReceipt());

        }

        private void monitoringUser_Click(object sender, RoutedEventArgs e)
        {
            FrameMenu.Navigate(new Pages.PageDirectoryCompany());
        }

        private void monitoringContainer_Click(object sender, RoutedEventArgs e)
        {
            FrameMenu.Navigate(new Pages.PageInfoContainer());

        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.IsEnabled = false;
            Windows.AddInfo registrat = new Windows.AddInfo();
            registrat.AddUsers.Visibility = Visibility.Visible;
            registrat.ShowDialog();

        }
        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.IsEnabled = false;
            Windows.AddInfo registrat = new Windows.AddInfo();
            registrat.AddProduct.Visibility = Visibility.Visible;
            registrat.ShowDialog();

        }

        #endregion

        #region User
        private void AddInfoContainer_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.IsEnabled = false;
            Windows.AddInfo registrat = new Windows.AddInfo();
            registrat.AddProductForContainer.Visibility = Visibility.Visible;
            registrat.ShowDialog();
        }
        #endregion


        private void AddGirectoryCompany_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.IsEnabled = false;
            Windows.AddInfo registrat = new Windows.AddInfo();
            registrat.AddDirectoryCompany.Visibility = Visibility.Visible;
            registrat.ShowDialog();
        }

        private void WatchInfoContainer_Click(object sender, RoutedEventArgs e)
        {
            FrameMenu.Navigate(new Pages.PageInfoContainer());

        }
    }
}
