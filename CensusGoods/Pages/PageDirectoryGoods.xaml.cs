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
using static CensusGoods.Class.DataUser;
namespace CensusGoods.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageDirectoryGoods.xaml
    /// </summary>
    public partial class PageDirectoryGoods : Page
    {
        int isAddEdit = 1;
        private Class.DirectGoogsHelper googsHelper = new Class.DirectGoogsHelper();
        public PageDirectoryGoods()
        {
            InitializeComponent();
            GridMain.ItemsSource = googsHelper.GetVm_DirComps();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            if (NameCompanyTBox.Text is null && PhoneTBox.Text is null)
                return;
            if (NameCompanyTBox.Text is null)
            {
                if (PhoneTBox.Text != null)
                {
                    GridMain.ItemsSource = googsHelper.GetVm_DirComps().Where(i => i.Номер_телефона_компании == (string)PhoneTBox.Text).ToList();
                }
            }
            else if (NameCompanyTBox.Text != null)
            {
                if (PhoneTBox.Text is null)
                {
                    GridMain.ItemsSource = googsHelper.GetVm_DirComps().Where(i => i.Название_компании == (string)NameCompanyTBox.Text).ToList();
                }
                else
                {
                    GridMain.ItemsSource = googsHelper.GetVm_DirComps().Where(i => i.Название_компании == (string)NameCompanyTBox.Text && i.Номер_телефона_компании 
                    == (string)PhoneTBox.Text).ToList();
                }
            }
        }

        private void RebootButton_Click(object sender, RoutedEventArgs e)
        {
            NameCompanyTBox.Text = null;
            NameCompanyTBox.Text = null;
            GridMain.ItemsSource = googsHelper.GetVm_DirComps();
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
