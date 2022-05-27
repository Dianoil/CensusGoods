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
    /// Логика взаимодействия для PageInfoContainer.xaml
    /// </summary>
    public partial class PageInfoContainer : Page
    {
        private Class.DirectCompanyHelper googsHelper = new Class.DirectCompanyHelper();

        public PageInfoContainer()
        {
            InitializeComponent();
            GridMain.ItemsSource = googsHelper.GetVm_InfoContainers();

        }


        private void RebootButton_Click(object sender, RoutedEventArgs e)
        {
            NameCompanyTBox.Text = null;
            GridMain.ItemsSource = googsHelper.GetVm_InfoContainers();

        }
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            if (NameCompanyTBox.Text is null)
                return;
            else if (NameCompanyTBox.Text != null)
            {
               
                    GridMain.ItemsSource = googsHelper.GetVm_InfoContainers().Where(i => i.Название_контейнера == (string)NameCompanyTBox.Text).ToList();
            }
        }
    }
}
