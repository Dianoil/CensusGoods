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
using static CensusGoods.Class.Enti;
namespace CensusGoods.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageReceipt.xaml
    /// </summary>
    public partial class PageReceipt : Page
    {
        private Class.DirectGoogsHelper googsHelper = new Class.DirectGoogsHelper();

        public PageReceipt()
        {
            InitializeComponent();
            GridMain.ItemsSource = googsHelper.GetVm_TotalReceipts();

        }

        private void RebootButton_Click(object sender, RoutedEventArgs e)
        {
            GridMain.ItemsSource = googsHelper.GetVm_TotalReceipts();
        }

    }
}
