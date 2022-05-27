using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using static CensusGoods.Class.Enti;
namespace CensusGoods.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageDirectoryCompany.xaml
    /// </summary>
    public partial class PageDirectoryCompany : Page
    {
        private Class.DirectCompanyHelper googsHelper = new Class.DirectCompanyHelper();

        public PageDirectoryCompany()
        {
            InitializeComponent();
            GridMain.ItemsSource = googsHelper.GetVm_DirUser();

        }
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            if (FIOTBox.Text is null)
                return;
            else
            {
                    GridMain.ItemsSource = googsHelper.GetVm_DirUser().Where(i => i.ФИО_Работника == (string)FIOTBox.Text).ToList();
            }
        }

        private void RebootButton_Click(object sender, RoutedEventArgs e)
        {
            FIOTBox.Text = null;
            GridMain.ItemsSource = googsHelper.GetVm_DirUser();
        }
    }
}
