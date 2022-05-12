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
        }
        //public enum pageDemo
        //{
        //    PageDirectoryGoods = 3,
        //    PageDirectoryCompany = 2
        //}
        //public void OpenPageDemo(pageDemo page)
        //{
        //    switch (page)
        //    {
        //        case pageDemo.PageDirectoryGoods:
        //            FrameMenu.Navigate(new PageDirectoryGoods(this));
        //            break;
        //        case pageDemo.PageDirectoryCompany:
        //            FrameMenu.Navigate(new PageDirectoryCompany(this));
        //            break;
        //    }
        //}
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

        }

        private void monitoringUser_Click(object sender, RoutedEventArgs e)
        {
            FrameMenu.Navigate(new Pages.PageDirectoryCompany());
        }

        private void monitoringContainer_Click(object sender, RoutedEventArgs e)
        {

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
    }
}
