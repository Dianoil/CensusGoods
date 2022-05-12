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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CensusGoods.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageDirectoryCompany.xaml
    /// </summary>
    public partial class PageDirectoryCompany : Page
    {
        int isAddEdit = 1;
        private Class.DirectCompanyHelper googsHelper = new Class.DirectCompanyHelper();

        public PageDirectoryCompany()
        {
            InitializeComponent();
            GridMain.ItemsSource = googsHelper.GetVm_DirUser();

        }
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            if (NameCompanyTBox.Text is null && FIOTBox.Text is null)
                return;
            if (NameCompanyTBox.Text is null)
            {
                if (FIOTBox.Text != null)
                {
                    GridMain.ItemsSource = googsHelper.GetVm_DirUser().Where(i => i.ФИО_Работника == (string)FIOTBox.Text).ToList();
                }
            }
            else if (NameCompanyTBox.Text != null)
            {
                if (FIOTBox.Text is null)
                {
                    GridMain.ItemsSource = googsHelper.GetVm_DirUser().Where(i => i.ФИО_Работника == (string)NameCompanyTBox.Text).ToList();
                }
                else
                {
                    GridMain.ItemsSource = googsHelper.GetVm_DirUser().Where(i => i.Компания == (string)NameCompanyTBox.Text && i.ФИО_Работника
                    == (string)FIOTBox.Text).ToList();
                }
            }
        }

        private void RebootButton_Click(object sender, RoutedEventArgs e)
        {
            NameCompanyTBox.Text = null;
            NameCompanyTBox.Text = null;
            GridMain.ItemsSource = googsHelper.GetVm_DirUser();
        }

        private void IsAddEdit(object sender, AddingNewItemEventArgs e)
        {

            isAddEdit = 1;
        }

        private void GridMain_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            isAddEdit = 1;
        }
    }
}
