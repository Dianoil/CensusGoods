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

namespace CensusGoods.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageWatchDirectoryGoods.xaml
    /// </summary>
    public partial class PageWatchDirectoryGoods : Page
    {
        int isAddEdit = 1;
        private Class.DirectCompanyHelper googsHelper = new Class.DirectCompanyHelper();
        //ObservableCollection<EF.Vm_DirGoods> productList = new ObservableCollection<EF.Vm_DirGoods>();
        public PageWatchDirectoryGoods()
        {
            InitializeComponent();
            GridMain.ItemsSource = googsHelper.GetVm_DirGoods();
            //productList = new ObservableCollection<EF.Vm_DirGoods>();
        }

        private void IsAddEdit(object sender, AddingNewItemEventArgs e)
        {

            isAddEdit = 1;
        }

        private void GridMain_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            isAddEdit = 1;
        }

        private void RebootButton_Click(object sender, RoutedEventArgs e)
        {
            NameCompanyTBox.Text = null;
            GridMain.ItemsSource = googsHelper.GetVm_DirGoods();

        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            if (NameCompanyTBox.Text is null)
                return;
            else if (NameCompanyTBox.Text != null)
            {
                GridMain.ItemsSource = googsHelper.GetVm_DirGoods().Where(i => i.Название_компании == (string)NameCompanyTBox.Text).ToList();
            }

        }

        //private void NameCompanyTBox_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    string txtOrig = NameCompanyTBox.Text;
        //    string upper = txtOrig.ToUpper();
        //    string lower = txtOrig.ToLower();

        //    var empFiltered = from Emp in productList
        //                      let ename = Emp.Название_компании
        //                      where
        //                       ename.StartsWith(lower)
        //                       || ename.StartsWith(upper)
        //                       || ename.Contains(txtOrig)
        //                      select Emp;

        //    GridMain.ItemsSource = empFiltered;
        //}
    }
}
